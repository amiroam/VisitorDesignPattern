using System;
using VisitorDesignPattern.ConcreteElements;
using VisitorDesignPattern.Interfaces;

namespace VisitorDesignPattern.Visitors
{
    public class Doctor : IVisitor
    {
        public string Name { get; set; }

        public Doctor(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            if (element is Kid kid)
            {
                Console.WriteLine($"Doctor: {Name} did a health checkup of the child: {kid.KidName}");
            }
        }
    }
}