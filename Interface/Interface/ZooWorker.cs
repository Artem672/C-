using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class ZooWorker : IWatch
    {
        public string WorkerName { get; set; }
        public void Watching(Zoo zoo)
        {
            Random rnd = new();
            int AnimalId = rnd.Next(0, zoo.animals.Count);
            Console.WriteLine($"{this.GetType().Name}: {WorkerName} is watching on: {zoo.animals[AnimalId].GetType().Name}:{zoo.animals[AnimalId].AnimalName}");
        }
        public void Feeding(Zoo zoo)
        {
            Random rnd = new();
            int AnimalId = rnd.Next(0, zoo.animals.Count);
            Console.WriteLine($"{this.GetType().Name}: {WorkerName} is feeding: {zoo.animals[AnimalId].GetType().Name}:{zoo.animals[AnimalId].AnimalName}");
        }
        public ZooWorker(string WorkerName)
        {
            this.WorkerName = WorkerName;
        }
    }
}
