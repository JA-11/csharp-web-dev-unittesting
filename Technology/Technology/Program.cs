using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer testComputer = new Computer(2, 3, true);
            Laptop testLaptop = new Laptop(2, 3, true, 7.5);
            
            
            SmartPhone android = new SmartPhone(1.5, 4, false, 100);
            android.TakePicture();
            Console.WriteLine(android.NumberOfPictures);


            //AbstractEntity test = new AbstractEntity();

            Console.WriteLine(testComputer.Id);
            Console.WriteLine(testLaptop.Id);
            Console.WriteLine(android.Id);

        }
    }
}