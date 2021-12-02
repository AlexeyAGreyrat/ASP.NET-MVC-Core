using Lesson4.Products;

namespace Lesson4.Model
{
    public sealed class DataCar : IData
    {
        private readonly Car _car;

        public DataCar(Car car)
        {
            _car = car;
        }

        public string Name { get => _car.Name; }
        public string Description { get => $"{_car.Description}. \n Size = {_car.Size} \n Category = {_car.Category}"; }
        public decimal Price { get => _car.Price; }

        public string Print()
        {
            return ($"Name {Name}.\n Description {Description}.\n Price {Price}");
        }
    }
}
