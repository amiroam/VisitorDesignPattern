using System;
using VisitorDesignPattern.ConcreteElements;
using VisitorDesignPattern.Interfaces;

namespace VisitorDesignPattern.Visitors
{
    public class Salesman : IVisitor
    {
        public string Name { get; set; }

        public Salesman(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            if (element is Kid kid)
            {
                Console.WriteLine($"Salesman: {Name} gave a school bag to the child: {kid.KidName}");
            }
        }
    }
}