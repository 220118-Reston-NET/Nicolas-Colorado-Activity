using CarFunction;


namespace SerializationFunction
{
    /*
        -serializetion is the process of converting your c# objects into a JSON file or 110001101
        stream of bytes) or other formats
        -We will be using JSON cuz it is the mostly commonly use dfile fromat for transfering/storing data
        -Main reason why is becasue collection memory is temp. and you might need to save data later on to be used
    */
    public class Serialization
    {
        //The period on the file path means to auto put the entire filepath of where this current file is at in your hard drive
        private static string _filepath = "./Database/Car.json";
        public static void SerialMain()
        {
            Console.WriteLine("===Serialization Demo===");

            Console.WriteLine("==Converting object to JSON==");
            List<Car> listofCars = new List<Car>();

            Car car1 = new Car();
            {
                Color = "Silver";
                Fuel = 50;
                Owner = "Stephen";
            };

            

            string jsonString = JsonSerializer.Serialize(car1, new JsonSerializerOptions {WriteIndented = true});
            Console.WriteLine(jsonString);

            File.WriteAllText(_filepath, jsonString);

            Console.WriteLine("=Converting JSON to objects=");
            string jsonString2 = File.ReadAllText(_filepath);

            Car car2 = JsonSerializer.Deserialize<Car>(jsonString2);

            Console.WriteLine(car2[0].Color);
            Console.WriteLine(car2[0].Fuel);
            Console.WriteLine(car2[0].Owner);
               
        }
    }
}