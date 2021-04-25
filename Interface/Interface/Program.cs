using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new();

            CreateAnimals(zoo);
            CreateVideoCameras(zoo);
            CreateZooWorkers(zoo);

            ConsoleKeyInfo pressedButton = Console.ReadKey();
            
            while(pressedButton.Key == ConsoleKey.Spacebar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tWelcome to zoo!");
                Console.ResetColor();
                RandomThings(zoo);
                pressedButton = Console.ReadKey();
                Console.Clear();
            }
        }

        static Random random = new();
        static void RandomThings(Zoo zoo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (random.Next(0,3))
            {
                case 0:
                    {
                        zoo.animals[random.Next(zoo.animals.Count)].AnimalEating();
                        break;
                    }
                case 1:
                    {
                        zoo.animals[random.Next(zoo.animals.Count)].AnimalSleeping();
                        break;
                    }
                case 2:
                    {
                        zoo.animals[random.Next(zoo.animals.Count)].AnimalWalking();
                        break;
                    }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (random.Next(0, 2))
            {
                case 0:
                    {
                        zoo.zooWorkers[random.Next(zoo.zooWorkers.Count)].Watching(zoo);
                        break;
                    }
                case 1:
                    {
                        zoo.zooWorkers[random.Next(zoo.zooWorkers.Count)].Feeding(zoo);
                        break;
                    }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            zoo.videoCameras[random.Next(zoo.videoCameras.Count)].Watching(zoo);
            Console.ResetColor();

        }
        static void ShowAnimal(Zoo zoo)
        {
            Animal animal = zoo.animals[random.Next(0, zoo.animals.Count)];

            int function = random.Next(0, 3);

            if (function == 1)
            {
                animal.AnimalEating();
            }
            else if (function == 2) 
            {
                animal.AnimalWalking();
            }
            else
            {
                animal.AnimalSleeping();
            }
        }
        static void ShowVideoCamera(Zoo zoo)
        {
            VideoCamera videoCamera = zoo.videoCameras[random.Next(0, zoo.videoCameras.Count)];

            videoCamera.Watching(zoo);
        }
        static void CreateAnimals(Zoo zoo)
        {
            string[] NameArray = new string[] { "Ponchik", "Snizynka", "Asya", "Persik", "Gefri" };
            string[] FoodType = new string[] { "Myaso", "Xleb", "Korm", "Morkva", "Salo" };
            for(int i = 0; i < random.Next(1,6);i++)
            {
                if (random.Next(100) % 2 == 1) 
                {
                    zoo.animals.Add(new Bear(NameArray[random.Next(NameArray.Length)], Convert.ToUInt32(random.Next(100)), FoodType[random.Next(FoodType.Length)], random.Next(90)));
                }
                else
                {
                    zoo.animals.Add(new Wolf(NameArray[random.Next(NameArray.Length)], Convert.ToUInt32(random.Next(100)), FoodType[random.Next(FoodType.Length)], random.Next(90)));
                }
            }           
        }
        static void CreateZooWorkers(Zoo zoo)
        {
            string[] NameArray = new string[] { "Alex", "Artem", "Nazar", "Fedor", "Oleg" };
            Random zooWorkers = new();

            for (int i = 0; i < zooWorkers.Next(1, 4); i++)
            {
                Random names = new();
                ZooWorker zooWorker = new(NameArray[names.Next(0, NameArray.Length)]);
                zoo.zooWorkers.Add(zooWorker);
            }
        }
        static void CreateVideoCameras(Zoo zoo)
        {
            Random video = new();
            for (int i = 0; i < video.Next(1, 5); i++)
            {
                VideoCamera videoCamera = new(i);
                zoo.videoCameras.Add(videoCamera);
            }
        }
    }

    
}
