public class Bigdog : Dog 
{
    public Bigdog(string name) : base(name){}
    public override void Greets()
    {
        System.Console.WriteLine("Woof");
    }
    public void Greeets()
    {
        System.Console.WriteLine("Wooooof");
    }
    public void Greetss(Bigdog another)
    {
        System.Console.WriteLine("Wooooooooof");
    }
}