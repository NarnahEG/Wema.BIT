namespace AreaofTriangleCalculator
{
    class program
    {
        public static void Main(string[] args) 
        {
            decimal baseh, height, area;

            Console.WriteLine("Area of Triangle Calculator");

            Console.WriteLine("Enter the base:");
            baseh = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the height:");
            height = Convert.ToDecimal(Console.ReadLine());

            area = (baseh * height) / 2;

            Console.WriteLine("The area of the triangle is:" + (area) );
        }
    }
}
    