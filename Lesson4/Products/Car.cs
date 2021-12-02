using System;

namespace Lesson4.Products
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }
    }

}
