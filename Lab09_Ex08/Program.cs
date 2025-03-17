Circle.PrintCircleArea(100);

class Circle
{
    const double PI = 3.14159;
    
    public static void PrintCircleArea(double radius)
    {
        // PI cannot be reassigned since it's a constant. If you need to modify it, remove 'const' and make it 'readonly' or a regular variable.
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}
