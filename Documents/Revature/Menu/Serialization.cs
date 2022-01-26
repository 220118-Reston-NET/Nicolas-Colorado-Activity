using System.Text.Json;
using MenuCollection;
using Empanada;

namespace SerializationFunction
{

    public class Serialization 
    {
        private static string _filepath = "./Database/Data.json";
        private List<string> _names = new List<string>();
        public static void SerialMain()
        {


            string jsonString = JsonSerializer.Serialize(_names, new JsonSerializerOptions {WriteIndented = true});
            Console.WriteLine(jsonString);

            File.WriteAllText(_filepath, jsonString);
            
            string jsonString2 = File.ReadAllText(_filepath);


        }

        private List<string> _names2 = new List<string>();
        
    }


}
