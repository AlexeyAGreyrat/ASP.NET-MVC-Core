using Lesson4.Products;
using System;

namespace Lesson4.Model
{
    public sealed class DataBike : IData
    {
        private readonly Bike _bike;

        public DataBike(Bike bike)
        {
            _bike = bike;
        }

        public string Name { get => _bike.Name; }
        public string Description { get => $"{_bike.Description}.\n Power = {_bike.Power}\n Color = {_bike.Color}";}
        public decimal Price { get => _bike.Price; }
        public string Print()
        {
            return Convert.ToString(($"Name {Name}.\n Description {Description}. \n Price: {Price}"));
        }
    }
}
