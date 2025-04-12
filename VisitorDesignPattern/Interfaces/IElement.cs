namespace VisitorDesignPattern.Interfaces
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}