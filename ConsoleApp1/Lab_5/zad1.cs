// See https://aka.ms/new-console-template for more information
class zad1
{
    static void Main(string[] args)
    { 
        Shape kolo=new Circle(5);
    }
}
abstract class Shape
{
    public abstract double CalculateArea();
}
class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double CalculateArea()
    {
        double area=Math.PI*radius*radius;
        return area;
    }
}
class Square : Shape
{
    private double a;
    public Square(double a)
    {
        this.a = a;
    }
    public override double CalculateArea()
    {
        double area = a*a;
        return area;
    }
}
public interface IVehicle
{
    int MaxSpeed { get; set; }
    void Start()
    {
        Console.WriteLine("Start");
    }
    void Stop();
}
public class Car : IVehicle
{
    public int MaxSpeed { get; set; }
    public void Start()
    {    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Bike : IVehicle
{
    public int MaxSpeed { get; set; }
    public void Start()
    { }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}


