using Hierarchy_TDD.Species;

namespace Hierarchy_TDD
{
    public static class AnimalID
    {
        public static Animal IdentifyAnimal(string[] inputArr)
        {
            Animal currentAnimal = null;
            if (inputArr?[0] == "Cat")
            {
                currentAnimal = new Cat(inputArr[0], inputArr[1], inputArr[2], inputArr[3], inputArr[4]);
            }

            if (inputArr?[0] == "Tiger")
            {
                currentAnimal = new Tiger(inputArr[0], inputArr[1], inputArr[2], inputArr[3]);
            }

            if (inputArr?[0] == "Mouse")
            {
                currentAnimal = new Mouse(inputArr[0], inputArr[1], inputArr[2], inputArr[3]);
            }

            if (inputArr?[0] == "Zebra")
            {
                currentAnimal = new Zebra(inputArr[0], inputArr[1], inputArr[2], inputArr[3]);
            }

            return currentAnimal;
        }
    }
}
