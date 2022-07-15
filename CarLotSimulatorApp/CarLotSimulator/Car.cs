using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
   public class Car
    { 
        public Car()
        {
            Carlot.NumberOfCars++;
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool IsDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = IsDriveable;
            Carlot.NumberOfCars++;

        }
      
        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }



        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"{HonkNoise}");
        }
        public void PrintMakeModel()
        {
            Console.WriteLine($"{Make} and {Model}");
        }
    }
}