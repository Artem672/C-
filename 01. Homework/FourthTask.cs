using System;

namespace FourthTask
{
    class Program
    {
        enum Planets
        {
            Mercury = 1,
            Venus,
            Earth,
            Mars,
            Jupiter,
            Saturn,
            Uranus,
            Neptune,
            Pluto
        }

        static void Main(string[] args)
        {
            Console.Write("Enter planet's number -> ");
            Planets pl = (Planets)(int.Parse(Console.ReadLine()));
            Console.Clear();
            switch(pl)
            {
                case Planets.Mercury:
                    Console.WriteLine("Mercury is the smallest and closest planet to the Sun in the Solar System.");
                    break;
                case Planets.Venus:
                    Console.WriteLine("Venus is the second planet from the Sun. It is named after the Roman goddess of love and beauty.");
                    break;
                case Planets.Earth:
                    Console.WriteLine("Earth is the third planet from the Sun and the only astronomical object known to harbor life.");
                    break;
                case Planets.Mars:
                    Console.WriteLine("Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System, being larger than only Mercury.");
                    break;
                case Planets.Jupiter:
                    Console.WriteLine("Jupiter is the fifth planet from the Sun and the largest in the Solar System.");
                    break;
                case Planets.Saturn:
                    Console.WriteLine("Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter.");
                    break;
                case Planets.Uranus:
                    Console.WriteLine("Uranus is the seventh planet from the Sun. Its name is a reference to the Greek god of the sky");
                    break;
                case Planets.Neptune:
                    Console.WriteLine("Neptune is the eighth and farthest-known Solar planet from the Sun. In the Solar System, it is the fourth-largest planet by diameter, the third-most-massive planet, and the densest giant planet.");
                    break;
                case Planets.Pluto:
                    Console.WriteLine("Pluto (minor planet designation: 134340 Pluto) is a dwarf planet in the Kuiper belt, a ring of bodies beyond the orbit of Neptune");
                    break;
            }
            Console.ReadKey();
        }
    }
}
