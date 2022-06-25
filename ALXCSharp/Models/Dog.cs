using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharp.Models
{
    public class Dog
    {
        public string Name
        {
            get;
            set;
        }
        public string Race { get; set; }
        // można nie pisać tych klamer tylko samo Race/Name

        // Name i Race to są properties


        //konstruktor:np 
        public Dog() {}

        public Dog(string name, string race)
        {
            Name = name;
            Race = race;
        }


        public void Bark()
        {
            Console.WriteLine("Hau");

        }
        public void Bite()
        {
            Console.WriteLine("Wrr!");
        }

        public void Present()
        {
            Console.WriteLine($"Attention here is {Race} named {Name}!");
        }

        public static void Run()
        {
            Console.WriteLine("[Dog] Run");
        }
    }
}
