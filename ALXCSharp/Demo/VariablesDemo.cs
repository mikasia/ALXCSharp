using System;

namespace ALXCSharp.Demo
{
    public class VariablesDemo
    {
        public static void Run()
        {
            Console.WriteLine("Variables demo");
            int number = 10;
            bool booleanValue = true;
            bool booleanValue1 = false;
            //string name = "Kasia";
            double number2 = 0.22;
            float number3 = (float) number2;

            //Console.WriteLine(name);
            Console.WriteLine(1);
            Console.WriteLine(booleanValue);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            //name
            string name = "Kasia";
            //lastName
            string lastName = "Kasia";
            //phoneNumber
            string phoneNumber = "0000";
            //height
            double heightInMeters = 1.78;
            //address
            string streetName = "Jasna";
            string buildingName = "6";
            string flatName = "25";
            string postalCode = "00-147";
            string city = "Warszawa";
            Console.WriteLine("Ul. " + streetName + " " + buildingName + "/" + flatName + "" + postalCode + " " + city);
            Console.WriteLine($"Ul. {streetName} {buildingName}/{flatName} {postalCode} {city}");
            Console.WriteLine("\n-----\n");


            //name
            Console.WriteLine("Personal data from \n");
            Console.Write("Enter name: ");
            string name1 = Console.ReadLine();
            //lastName
            Console.Write("Enter last name: ");
            string lastName1 = Console.ReadLine();
            //phoneNumber
            Console.Write("Enter phone number: ");
            string phoneNumber1 = Console.ReadLine();
            //height
            Console.Write("Enter height: ");
            double heightInMeters1 = Convert.ToDouble(Console.ReadLine());
            //address
            Console.Write("Enter street name: ");
            string streetName1 = Console.ReadLine();
            Console.Write("Enter building number: ");
            string buildingName1 = Console.ReadLine();
            Console.Write("Enter flat number: ");
            string flatName1 = Console.ReadLine();
            Console.Write("Enter postal code: ");
            string postalCode1 = Console.ReadLine();
            Console.Write("Enter city: ");
            string city1 = Console.ReadLine();
            string address1 = $"Ul. {streetName1} {buildingName1} / {flatName1} {postalCode1} {city1}";
            Console.WriteLine();
            Console.WriteLine($"{name1} {lastName1} \nheight: {heightInMeters1} phone number: {phoneNumber1} " + $"\nAddress: {address1}");
            Console.WriteLine("Ul. " + streetName1 + " " + buildingName1 + "/" + flatName1 + " " + postalCode1 + " " + city1);
            Console.WriteLine($"Ul. {streetName1} {buildingName1} / {flatName1} {postalCode1} {city1}");
        }

        public static void RunCalculator()
        {
            Console.WriteLine("Simple Calculator");
            Console.Write("Enter x number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {Convert.ToDouble(x) / Convert.ToDouble(y)}");
            Console.WriteLine($"{x} modulo {y} = {x % y}");
        }

        public static void RunLogicalCalculator()
        {
            Console.WriteLine("Simple Logical Calculator");
            Console.Write("Enter x number: ");
            bool x = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter y number: ");
            bool y = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{x} AND {y} = {x && y}");
            Console.WriteLine($"{x} OR {y} = {x || y}");
            Console.WriteLine($"{x} XOR {y} = {x ^ y}");

        }
    }

}
