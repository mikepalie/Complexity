using System;

namespace BubbleSort
{
    class Sorting
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Age = 33, Name = "Mixalis" };
            Student s2 = new Student() { Age = 19, Name = "Maria" };
            Student s3 = new Student() { Age = 22, Name = "Damianos" };
            Student s4 = new Student() { Age = 18, Name = "Takis" };

            Student[] students = { s1, s2, s3, s4 };

            Print(students,"Original Array");
            BubbleSortOrderBy(students);
            Print(students,"Sorted Array");
        }

        private static void Print(Student[] sortdedData, string message)
        {
            Console.WriteLine($"{message}");
            foreach (Student s in sortdedData)
                Console.WriteLine($"{s.Name, -15}{s.Age,-15}");
        }

        private static void BubbleSortOrderBy(Student[] mixdata)
        {
            Student temp;
            int size = mixdata.Length - 1;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    if (mixdata[i].Age > mixdata[i + 1].Age)
                    {
                        temp = mixdata[i + 1];
                        mixdata[i + 1] = mixdata[i];
                        mixdata[i] = temp;
                    }
                }
            }
        }
    }
}

class Student
{
    public int Age { get; set; }
    public string Name { get; set; }
}