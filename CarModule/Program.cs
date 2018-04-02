using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using CarModule;
using System.Threading;
using Newtonsoft.Json.Linq;
using System.Net;
using RabbitMQ.Client;

namespace CarModule
{
    class Program
    {
        static void Main(string[] args)
        {
            //Connection to RabbitMQ
            ConnectionFactory factory = new ConnectionFactory
            {
                UserName = "test",
                Password = "Zxvcasfd",
                HostName = "51.144.119.126"
            };
            IConnection connection = factory.CreateConnection();


            Car car1 = new Car("car-1", 3, connection);
            Car car2 = new Car("car-2", 5, connection);
            Car car3 = new Car("car-3", 4, connection);
            Car car4 = new Car("car-4", 6, connection);
            Car car5 = new Car("car-5", 3, connection);
            Car car6 = new Car("car-6", 2, connection);
            Car car7 = new Car("car-7", 6, connection);
            Car car8 = new Car("car-8", 11, connection);

            car1.PointFrom = "A";
            car2.PointFrom = "X";
            car3.PointFrom = "B";
            car4.PointFrom = "E";
            car5.PointFrom = "G";
            car6.PointFrom = "Y";
            car7.PointFrom = "Z";
            car8.PointFrom = "N";

            Thread car1Task = new Thread(() => Car.Work(car1));
            Thread car2Task = new Thread(() => Car.Work(car2));
            Thread car3Task = new Thread(() => Car.Work(car3));
            Thread car4Task = new Thread(() => Car.Work(car4));
            Thread car5Task = new Thread(() => Car.Work(car5));
            Thread car6Task = new Thread(() => Car.Work(car6));
            Thread car7Task = new Thread(() => Car.Work(car7));
            Thread car8Task = new Thread(() => Car.Work(car8));
            car1Task.Start();
            car2Task.Start();
            car3Task.Start();
            car4Task.Start();
            car5Task.Start();
            car6Task.Start();
            car7Task.Start();
            car8Task.Start();
            Console.Read();
        }

    }
}