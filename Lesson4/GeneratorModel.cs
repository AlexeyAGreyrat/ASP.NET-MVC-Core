using Bogus;
using Lesson4.Products;

namespace Lesson4
{
    public class GeneratorModel
    {
        public void GetCar(ISerializer serializer, int count = 1)
        {
            serializer.Serialize(FakerCar.Generate(count));
        }

        public void GetBike(ISerializer serializer, int count = 1)
        {
            serializer.Serialize(FakerBike.Generate(count));
        }

        private Faker<Car> FakerCar = new Faker<Car>().Rules((f, c) =>
        {
            c.Id = f.Random.Guid();
            c.Name = f.Commerce.ProductName();
            c.Description = f.Lorem.Paragraph();
            c.Category = f.Commerce.ProductAdjective();
            c.Price = f.Random.Decimal(30, 60);
            c.Size = f.Finance.Random.Int(85, 250);
        });

        private Faker<Bike> FakerBike = new Faker<Bike>().Rules((f, c) =>
        {
            c.Id = f.Random.Guid();
            c.Name = f.Commerce.ProductName();
            c.Description = f.Lorem.Paragraph();
            c.Color = f.Commerce.Color();
            c.Price = f.Random.Decimal(30, 60);
            c.Power = f.Finance.Random.Int(85, 250);
        });
    }



}
