using System;
using System.Linq;
namespace LessonL6
{
    class LessonL6
    {
        public static void Main(string[] args)
        {
            string[] carModelsArray = new[] { "Mazda", "Toyota", "Ferrari", "Volvo" };
            string[,] testMarksArray = new string[3, 2] { { "Dosha", "10" }, { "Dimas", "9" }, { "Emil", "5" } };
            string assigment = "I am working on, assigment";
            var assigmentArray = assigment.Split(' '); //Split

            var splitAssigmentArray = assigment.Split(',');

            var removedIAssigment = assigment.Remove(1); //Remove

            var numberOfCars = carModelsArray.Count(); //1st Methode Use
            Console.WriteLine(numberOfCars);

            Array.Sort(carModelsArray); //2nd Method

            foreach (var carModel in carModelsArray)
            {
                Console.WriteLine(carModel);
            }

            var totalNumberOfFields = testMarksArray.Length; //1st Methode Use for Matrix
            Console.WriteLine(totalNumberOfFields);

            var rank = testMarksArray.Rank; //2nd Methode Use for Matrix
            Console.WriteLine(rank);

            foreach (var testMarks in testMarksArray)
            {
                Console.WriteLine(testMarks);
            }

            foreach (var assigmentt in assigmentArray)
            {
                Console.WriteLine(assigmentt);
            }

            foreach (var splitAssigment in splitAssigmentArray)
            {
                Console.WriteLine(splitAssigment);
            }

            Console.WriteLine(removedIAssigment);

        }
    }
}