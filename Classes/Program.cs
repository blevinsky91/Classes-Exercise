namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Car car1 = new Car();
            car1.Make = "Doge";
            car1.Model = "Ram";
            car1.Year = 2018;
            Console.WriteLine(car1.Make);
            Console.WriteLine(car1.Model);
            Console.WriteLine(car1.Year);
        }
    }
}
