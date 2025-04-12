using System;
using VisitorDesignPattern.ObjectStructure;
using VisitorDesignPattern.Visitors;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School();

            var doctor = new Doctor("James");
            school.PerformOperation(doctor);

            Console.WriteLine();

            var salesman = new Salesman("John");
            school.PerformOperation(salesman);

            Console.ReadLine();
        }
    }
}