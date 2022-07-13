using CarLotSimulator;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //Now that the Car class is created we can instanciate 3 new cars
            Carlot carlotList = new Carlot();
            
            
            Car newCar = new Car();
            newCar.Year = 1954;
            newCar.Make = "Chevy";
            newCar.Model = "BelAir";
            newCar.EngineNoise = "WaWaWaWaWa";
            newCar.HonkNoise = "AhWOOOOOOGA";
            newCar.IsDriveable = true;
            
            newCar.MakeEngineNoise();
            newCar.MakeHonkNoise();
            newCar.PrintMakeModel();

            carlotList.CarLotList.Add(newCar);

            var newerCar = new Car()
            {
                Year = 1992,
                Make = "Lamborgini",
                Model = "Diablo VT",
                EngineNoise = "VaVaVoom",
                HonkNoise = "MEEP",
                IsDriveable = true
            };

            newerCar.MakeEngineNoise();
            newerCar.MakeHonkNoise();
            newerCar.PrintMakeModel();

           carlotList.CarLotList.Add(newerCar);

            Car newestCar = new Car(1969, "Chevy", "Camaro", "DUDUDUDUDUDU", "Pow", true);

            newestCar.MakeEngineNoise();
            newestCar.MakeHonkNoise();
            newestCar.PrintMakeModel();

            
            carlotList.CarLotList.Add(newestCar);


            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
