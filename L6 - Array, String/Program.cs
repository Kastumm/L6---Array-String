using System;
using System.Linq;
using System.Text;

namespace LessonL6
{
    class LessonL6
    {
        public static void Main(string[] args)
        {
            string[] carModelsArray = new[] { "Mazda", "Toyota", "Ferrari", "Volvo" }; // One-DImensional Array
            string[,] testMarksArray = new string[3, 2] { { "Dosha", "10" }, { "Dimas", "9" }, { "Emil", "5" } }; //Multi-Dimensional Array
            string assignment = "I am working on, assigment";
            var assignmentArray = assignment.Split(' '); //Split

            var splitAssignmentArray = assignment.Split(',');

            var removedIAssignment = assignment.Remove(1); //Remove

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

            foreach (var assignmentt in assignmentArray)
            {
                Console.WriteLine(assignmentt);
            }

            foreach (var splitAssignment in splitAssignmentArray)
            {
                Console.WriteLine(splitAssignment);
            }

            Console.WriteLine(removedIAssignment);

            ///String Builder
            StringBuilder cars = new StringBuilder("Mercedes", 20); //Maximum capacity of the builder, it will automaticaly double if full.

            cars.AppendLine(" Benz");
            cars.Append("Mercedes");
            cars.AppendLine(" S Model");

            cars.Remove(4, 4);
            cars.Replace("Mercedes", "Audi");

            var goodCar = cars.ToString();
            Console.WriteLine(goodCar);
            ///

        }
    }
}