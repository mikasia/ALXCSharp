using ALXCSharp.Models;

namespace ALXCSharp.Demo
{
    public static class ClassesDemo
    {
        public static void Run()
        {
            // NazwaKlasy nazwaObiektu = new NazwaKlasy();
            Dog westieDog = new Dog();
            westieDog.Name = "Skiper";
            westieDog.Race = "West";
            westieDog.Bark();
            westieDog.Bite();
            westieDog.Present();

            Dog labradorDog = new Dog();
            labradorDog.Name = "Borys";
            labradorDog.Race = "Labrador";
            labradorDog.Bark();
            labradorDog.Bite();
            labradorDog.Present();

            Dog goldenDog = new Dog
            {
                Name = "Misio",
                Race = "Golden Retriever"
            };
            goldenDog.Bark();
            goldenDog.Bite();
            goldenDog.Present();

            Dog borderDog = new Dog("Java", "Border");
            borderDog.Bark();
            borderDog.Bite();
            borderDog.Present();
            Dog.Run();

            // stateczna mozna wywolac tylko na klasie a nie na obiekcie, jak nie jest statyczna to musi być stworzony obiekt; czyli niestatyczna nie zadziala na klasie
            // referencja, typy referencyjne - stack i heap(sterta) i typy obiektowe; są też typy własne
        }
    }
}
