using System;

namespace Exercise6
{
    internal class DogTest
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Max", "male");
            Dog dog2 = new Dog("Rocky", "male");
            Dog dog3 = new Dog("Sparky", "male");
            Dog dog4 = new Dog("Buster", "male");
            Dog dog5 = new Dog("Sam", "male");
            Dog dog6 = new Dog("Lady", "female");
            Dog dog7 = new Dog("Molly", "female");
            Dog dog8 = new Dog("Coco", "female");
            dog1.SetParents(dog6, dog2);
            dog8.SetParents(dog7, dog4);
            dog2.SetParents(dog7, dog5);
            dog4.SetParents(dog6, dog3);

            Console.WriteLine(dog8.FatherName());
            Console.WriteLine(dog3.FatherName());

            Console.WriteLine(dog8.HasSameMother(dog2));
            Console.WriteLine(dog8.HasSameMother(dog5));
        }
    }
}
