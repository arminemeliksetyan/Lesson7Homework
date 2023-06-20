namespace Lesson7Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car("Bmw", "M5", 2022, 5.5f, "pink", 50000m);
            //Car car2 = new Car("Mercedes", "Cls", 2023, 5.5f, "yellow", 70000m);

            //car1.Print();


            //Console.Write("Model - ");
            //string model = Console.ReadLine();
            //Console.Write("Marka - ");
            //string marka = Console.ReadLine();
            //Console.Write("Year - ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Motor - ");
            //float motor = Convert.ToSingle(Console.ReadLine());
            //Console.Write("Color - ");
            //string color = Console.ReadLine();
            //Console.Write("Price - ");
            //decimal price = Convert.ToDecimal(Console.ReadLine());

            Car cars = new Car(model, marka, year, motor, color, price);
            cars.Print();

            //cars[0] = new Car("Bmw", "M5", 2022, 5.5f, "pink", 50000m);
            //cars[1] = new Car("Mercedes", "Cls", 2023, 5.5f, "yellow", 70000m);
            //cars[2] = new Car("Nissan", "X-Trail", 2003, 2.0f, "white", 7000m);
            //cars[3] = new Car("Hundai", "Elision", 2009, 2.5f, "black", 12000);
            //cars[4] = new Car("Mercedes", "AMG", 2010, 5.0f, "black", 60000);

            //2015 tvic barcr meqenan
            //foreach (Car car in cars)
            //{
            //    if(car.year > 2015)
            //    {
            //        car.Print();
            //    }
            //}

            //amenatank meqenan

            //decimal max = cars[0].price;
            //Car temp = cars[0];
            //foreach(Car car in cars)
            //{
            //    if(car.price> max)
            //    {
            //        max = car.price;
            //        temp = car;
            //    }
            //}

            //Console.WriteLine(max);
            //temp.Print();

        }
        public static void SignIn() 
        {
            Console.Write("Model - ");
            string model = Console.ReadLine();
            Console.Write("Marka - ");
            string marka = Console.ReadLine();
            Console.Write("Year - ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Motor - ");
            float motor = Convert.ToSingle(Console.ReadLine());
            Console.Write("Color - ");
            string color = Console.ReadLine();
            Console.Write("Price - ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
        }
    }
}