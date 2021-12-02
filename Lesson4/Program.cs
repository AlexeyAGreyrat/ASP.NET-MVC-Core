using System;
using System.Collections.Generic;
using System.IO;
using Lesson4.Model;
using Lesson4.Products;
using Lesson4.Strategy;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratorModel generator = new GeneratorModel();

            ISerializer jsonSerializer = new JsonSerializator();
            ISerializer xmlSerializer = new XMLSerializator();

            generator.GetCar(jsonSerializer, 4);
            generator.GetBike(xmlSerializer, 4);
             

            IDeserializer deserializer = new BikeStrategy();
            var context = new DeserializatoinContext(new StreamReader("Bike.xml"));
            context.SetupDeserializatoinStrategy(deserializer);
            context.Execute();
            var listBike = (List<Bike>)context.Result;
            foreach(var bike in listBike)
            {
                IData data = new DataBike(bike);
                Console.WriteLine(data.Print());
            }

            deserializer = new CarStrategy();
            context = new DeserializatoinContext(new StreamReader("Car.json"));
            context.SetupDeserializatoinStrategy(deserializer);
            context.Execute();
            var listCar = (List<Car>)context.Result;
            foreach (var car in listCar)
            {
                IData data = new DataCar(car);
                Console.WriteLine(data.Print());
            }


        }
    }
}
