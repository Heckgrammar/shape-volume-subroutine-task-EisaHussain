namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write subroutines to calculate the areas of 
            // Circle
            // Triangle
            // Rectangle
            // Pentagon
            // Octagon
        }
        static int areaOfRectangle(int width, int length)//Add the parameters
        {
            return width * length;
        }
        static float areaOfCircle(float radius)
        {
            radius = radius * radius;
            return radius * 3.14
        }
        static int areaOfTriangle (int width, int length)
        {
            return (width * length) / 2;
        }

    }
}
