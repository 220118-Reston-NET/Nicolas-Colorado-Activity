namespace ConversionFunction
{
    public class Conversion 
    {
        //Static fields are shared between al objects from this class
        //In this way if you need an universal info that needs to be stored and shared to every onject from this
        //Use static field
        public static int _num;
        public static void ConversionMain()
        {
            //Implicit - just means something is done automatically (compiler)
            //Explicit - just means you have to write something to do it

            Console.WriteLine("===Conversion Demo===");
            int x = 10;
            double y = 85.29;
            string str = "Hello world";
            string 

            //Implicit conversion
            //The general rule is if you are going from a datatype to another datatype
            //without losing info
            double anotherDouble = x;
            Console.WriteLine(anotherDouble);

            //Explicit conversion
            //The general rule is if you are going to lose information if you are trying to convert
            //The compiler won't do it for you for obvious reasons.
            int anotherInt = (int)y;
            Console.WriteLine(anotherInt);

            double anotherDouble2 = Convert.ToDouble(doubleStr);
            
        }

        public int GiveMeNumber()
        {
            return _num;
        }
    }
}