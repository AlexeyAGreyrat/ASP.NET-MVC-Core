namespace Lesson4.Model
{
    public interface IData
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        string Print();
    }
}
