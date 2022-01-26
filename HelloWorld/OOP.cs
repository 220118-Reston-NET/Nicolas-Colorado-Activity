namespace OOPFunction
{
    public static void OOPMain()
    {
        Console.WriteLine("Inheritance Demo");
        Dog dog1 = new Dog();
        dog1.Talk();
        dog1.Talk("german Shepard");
        Console.WriteLine(dog1.Name);

        Dog dog2 = new Dog("Minnie");
        Console.WriteLine(dog2.Name);
    }
}

//Base/parent class
public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }
    public virtual void Talk()
    {
        Console.WriteLine("Animal is talking!");

    }

    //Method Overloading
    //when two methods have the same name but different parameters 
    //and implementation details
    //only works with parameters
    //can only return one type
    public void Talk(string p_talk)
    {
        Console.WriteLine(p_talk + " is talking!");
    }

    public Animal()
    {
        Name = "Animal";
        Color = "Navy Blue";
    }

    public Animal(string p_name)
    {
        Name = p_name;
        Color = "Navy Blue";
    }

}

//Inheriance is enoted by a ":" syntax
//Derived/child class
//Constructors are a bit special in that they aren't inherited but
//the defualt base class contructor will run whenever you create an 
//object out of a derived class
public class Dog : Animal
{
    public Dog() : base()
    {

    }
    public Dog(string p_name): base(p_name)
    {

    }

    //Method Overriding
    //when a derived class changes the function/implemeentation detail
    //of the base class
    //It needs to use virtual and ovveride keywords (non-access modeifiers)
    //to tell the compiler that we are trying to acheive method overriding
    //It needs to have the same method and same parameters
    public override void Talk()
    {
        Console.WriteLine("Barking!");
    }
}
