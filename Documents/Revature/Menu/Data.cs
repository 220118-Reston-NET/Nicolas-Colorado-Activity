//This is the Data file whihc holds the Collection classes

using System.Collections;
using SerializationFunction;

namespace MenuCollection
{
    public class MenuData
    {
        private List<string> _strings = new List<string>();
        Serialization name1 = new Serialization();

        public void AddStrings(string inputVal)
        {
            _strings.Add(inputVal);
        }

        public void ShowStrings()
        {
            foreach (string item in _strings)
            {
                Console.WriteLine(item);
            }
        }
        public void RemoveStrings(string inputVal)
        {
            _strings.Remove(inputVal);
        }

        public void SearchStrings()
        {
            Console.WriteLine("Enter the name you want to search for:");
            string inputVal = Console.ReadLine();

            if (_strings.Contains(inputVal))
            {
                Console.WriteLine($"There is an online order for {_strings}");
                
            }
            else
            {
                Console.WriteLine("The name you're searching for does not exist");
            }
        }

        public void PrintStrings()
        {
            name1.SerialMain();
        }

    }
}
