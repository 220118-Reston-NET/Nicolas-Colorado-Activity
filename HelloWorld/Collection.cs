using System.Collections;

namespace CollectionFunction
{
    public class CollectionFunction
    {
        //Array
        //Used to store a datatype and have a fixed size
        //syntax: (datatype)[] (name of variable) = new (datatype)[size of the array)];
        private int[] _nums = new int[5];

        //Generic Collection
        //They store a specific datatype and have a variable size
        //Syntax: <(datatype)>
        private ArrayList _nonGeneric = new ArrayList();

        //List collection
        //Zero-based index
        //Used to store a datatype and has variable size

        private List<string> _strings = new List<string>();

        //Hashset Collection
        //There is no particular order to the elements
        //you can not duplicate elements
        private HashSet<int> _numsCollection = new HashSet<int>();

        //Dictionary collection
        //Stores information through key-value pairs
        //There is not particula order

        private Dictionary<string,int> directory = new Dictionary<string, int>;



        //Non-generic collection
        //They store any datatype and have variable size

        public void CollectionMain()
        {
            Console.WriteLine("===Collecction Demo===");

            _nums[0] = 3;
            _nums[1] = 10;
            _nums[2] = 4;

            //A way to go through a list
            //Foreach will iterate through all of the elements of a collection or array
            //Syntax: ( (datatype) )
            foreach (int num in _nums)
            {
                Console.WriteLine(_nums);
            }
            
            //For loop is for a more complex way to iterate through a collection
            //Syntax: ((block 1 used to initialize some temp variable))
            Console.WriteLine("===For Loop===");
            for (int i = 0; i < _nums.Length; i+=2)
            {
                Console.WriteLine("current value of i: "+ i);
                Console.WriteLine(_nums[i]);
            }

            Console.WriteLine("===Generic Collection===");
            Console.WriteLine("==List Demo==");
            _strings.Add("First element");
            _strings.Add("Second element");
            _strings.Add("third element");
            _strings.Add("First element");

            foreach(string item in strings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(_strings[1]);

            Console.WriteLine("==Hashset Demo==");
            _numsCollection.Add(1);
            _numsCollection.Add(2);
            _numsCollection.Add(1);
            _numsCollection.Add(1);

            foreach (int item in _numsCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==Dictionary Demo");
            _directory.Add("Stephen", -10000);
            _directory.Add("Vijhan", 1000);
            _directory.Add("Johnathan", -100000);
            //_directory.Add("Stephen", 1000); Will get an exception cuz he already exists

            //Dictionary used key to loop up information
            Console.WriteLine(_directory["Stephen"]);
            Console.WriteLine(_directory["Johnathan"]);

            Console.WriteLine("===NonSerializedAttribute Generic Collection===");

            _nonGeneric.Add("Stephen");
            _nonGeneric.Add(10);
            _nonGeneric.Add(true);
            _nonGeneric.Add(10.70);
            
            _strings[0].ToUpper();
            //_nonGeneric[0].ToUpper(); will not work due to the element being an object as it was 
            //autoboxing from a string initially
        }
    }
}