internal class Program
{
    private static void Main(string[] args)
    {
        Developer dev = new PanelDeveloper("ООО КирпичСтрой");
        House PHouse = dev.Create();

        dev = new WoodDeveloper("Частный застройщик");
        House WHouse = dev.Create();

        Console.ReadKey();
    }
}

/*abstract class Product
{ }

class ConcreteProductA : Product
{ }

class ConcreteProductB : Product
{ }

abstract class Creator
{
    public abstract Product FactoryMethod();
}


class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

class ConcreteCreatorB : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductB();
    }
}
формальное определение паттерна
*/

abstract class House //Product
{ }

class PanelHouse : House//ConcreteProductA : Product
{
    public PanelHouse()
    {
        Console.WriteLine("Панельный дом построен");
    }
}

class WoodHouse : House//ConcreteProductB : Product
{
    public WoodHouse()
    {
        Console.WriteLine("Деревянный дом построен");
    }
}

abstract class Developer//Creator
{
    public string Name { get; set; }

    public Developer(string n) 
    {
        Name = n;
    }

    public abstract House Create(); //Product FactoryMethod();
}


class PanelDeveloper : Developer//ConcreteCreatorA : Creator
{
    public PanelDeveloper(string n) : base(n)
    { }

    public override House Create()//Product FactoryMethod()
    {
        return new PanelHouse();//ConcreteProductB();
    }
}

class WoodDeveloper : Developer//ConcreteCreatorB : Creator
{
    public WoodDeveloper(string n) : base(n) { }

    public override House Create()
    {
        return new WoodHouse();//ConcreteProductB();
    }
}