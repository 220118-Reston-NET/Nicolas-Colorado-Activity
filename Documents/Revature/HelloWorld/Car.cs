//Namespace is a great way to organize your code
namespace CarFunction
{
    // This is how you create a class using the class keyword
    //
    public class Car
    {
        //Field 
        //It is used to store information or define current state of the object when you make it
        //private means only the class itself can use this field
        private string _color = "Blue";
        private string _owner;
        private int _fuel;
        private int _gallonPerMile;

        //property
        //they are in PascalCase ThisIsHowPascalCaseWillShows
        public string Color
        {
            //get keyword is a property used to make one of your private fields readable
            get { return "The color is"+_color; }
            //set keyword is a roperty used to make one of your privte fields writable
            set { _color = value; }
        }

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public int Fuel { get; set; }

        //A moethodd will run mutliple lines of code to do some sort of opertion/behavior/function
        //void this method will return/giv back nothing
        //we can change this void into another datatype if you want the method to give info back

        public Car()
        {
            Console.WriteLine("Creating a car!");
            _color = "Blue";
            _gallonPerMile = 10;
            _owner = "No Owner";
            Fuel = 100;
        }

        public void Start()
        {
            Console.WriteLine("The car is starting right now!");
            Console.WriteLine($"Current fuel: {Fuel}");
        }

        //You can add parameters to a method to pass in data to be used in method
        public void Start(int p_fuel)
        {
            Fuel = p_fuel;
            Console.WriteLine("The car is starting right now!");
            Console.WriteLine($"Current fuel: {Fuel}");
        }

        //Will give total distance on car
        //Methods can return data back if didn't put void
        public double TotalDistance()
        {

            return (double)Fuel/_gallonPerMile;
        }
    

    }
}
