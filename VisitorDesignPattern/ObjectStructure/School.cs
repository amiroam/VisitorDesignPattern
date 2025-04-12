using System.Collections.Generic;
using VisitorDesignPattern.Interfaces;
using VisitorDesignPattern.ConcreteElements;

namespace VisitorDesignPattern.ObjectStructure
{
    public class School
    {
        private readonly List<IElement> _elements;

        public School()
        {
            _elements = new List<IElement>
            {
                new Kid("Ram"),
                new Kid("Sara"),
                new Kid("Pam")
            };
        }

        public void PerformOperation(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}