Circle.PrintCircleArea(100);

class Circle
{
    // เปลี่ยนจาก const เป็น readonly หรือแค่ตัวแปรธรรมดา
    static double PI = 3.14159;  // สามารถปรับค่าได้
    public static void PrintCircleArea(double radius)
    {
        PI = 3.14159265359;  // เปลี่ยนค่าของ PI เพื่อเพิ่มความแม่นยำ
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}
