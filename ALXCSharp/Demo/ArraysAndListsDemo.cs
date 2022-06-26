
using ALXCSharp.Models;
using System;
using System.Collections.Generic;

namespace ALXCSharp.Demo
{
    public class ArraysAndListsDemo
    {
        public static void Run()
        {
            int x = 4;
            // typ[] nazwa = newt typ[numberOfElements];
            int[] array1 = new int[7];
            array1[0] = 4;
            array1[1] = 2;
            array1[2] = 1;
            array1[3] = 0;
            array1[4] = 3;
            array1[5] = 4;
            array1[6] = 1;
            // typ[] nazwa = {elementy}
            int[] array2 = { 4, 2, 1, 0, 3, 4, 1 };
            // te dwie powyzsze są takie same tylko inny sposob zapisu

            int[,] twoArray = new int[2, 7];
            int[,,] threeArray = new int[2, 7, 6];


            //foreaech(type of elementName in arrayName)
            Console.WriteLine("Array1");
            foreach(int number in array1)
            {
                Console.Write($"{number}, ");
            }
            Console.WriteLine("Array2");
            foreach (int number in array2)
            {
                Console.Write($"{number}, ");
            }

            

            Dog[] dogArray = new Dog[3];
            dogArray[0] = new Dog("Mickey", "GR");
            dogArray[1] = new Dog("Azor", "GR");
            dogArray[2] = new Dog("Hejo", "GR");

            // inny sposob zapisu tablicy:
            Dog westieDog = new Dog("name", "hej");
            Dog[] dogArray2 = { westieDog, new Dog("name", "hejo") };

            foreach(Dog dog in dogArray)
            {
                dog.Present();
                dog.Bark();
            }

        }
        public static void RunLists()
        {
            // var - can be any type, its used in methods (not usable for declaring class properties)
            Dog dog1 = new Dog("Mickey", "GR");
            Dog dog2 = new Dog("Azor", "GR");
            Dog dog3 = new Dog("Hejo", "GR");
            int x = 4;
            var y = 5;
            var v = new Dog();

            //List<ListElementClass> listName = new List<ListElementClass>()
            //List<Dog> dogs = new List<Dog>();
            var dogs = new List<Dog>();

            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog2);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog3);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog1);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Remove(dog2);
            Console.WriteLine($"List Size: {dogs.Count}");

            foreach(var dog in dogs)
            {
                dog.Present();
            }


        }
    }
}
