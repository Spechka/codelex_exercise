using Hierarchy_TDD.FoodTypes;
using Hierarchy_TDD.Species;
using System;
using System.Collections.Generic;

namespace Hierarchy_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            while (true)
            {
                Console.WriteLine(">> Input guide - {AnimalType} {AnimalName} {Weight} {Region} {Catbreed- ifCat}<<\n");
                var input = Console.ReadLine();

                if (input == "End" || input == "end")
                {
                    break;
                }
                else
                {
                    var inputArr = input.Split(' ');
                    Animal currentAnimal = new Tiger("", "", "2", "");

                    if (inputArr[0] == "Cat")
                    {
                        currentAnimal = new Cat(inputArr[0], inputArr[1], inputArr[2], inputArr[3], inputArr[4]);
                        animals.Add(currentAnimal);
                    }
                    else if (inputArr[0] == "Tiger")
                    {
                        currentAnimal = new Tiger(inputArr[0], inputArr[1], inputArr[2], inputArr[3]);
                        animals.Add(currentAnimal);
                    }
                    else if (inputArr[0] == "Mouse")
                    {
                        currentAnimal = new Mouse(inputArr[0], inputArr[1], inputArr[2], inputArr[3]);
                        animals.Add(currentAnimal);
                    }
                    else if (inputArr[0] == "Zebra")
                    {
                        currentAnimal = new Zebra(inputArr[0], inputArr[1], inputArr[2], inputArr[3]);
                        animals.Add(currentAnimal);
                    }

                    currentAnimal.MakeSound();
                    Feed(currentAnimal);
                    Console.WriteLine(currentAnimal);
                    Console.WriteLine("-----------------");
                }
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.ReadKey();
        }

        public static void Feed(Animal animal)
        {
            var input = Console.ReadLine().Split(" ");
            if (input[0] == "Meat")
            {
                animal.Eat(new Meat(input[1]));
            }
            else
            {
                animal.Eat(new Vegetable(input[1]));
            }
        }
    }
}