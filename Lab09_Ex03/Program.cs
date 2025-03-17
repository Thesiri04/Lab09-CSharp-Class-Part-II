var person = new Person();
person.name = "noey";
System.Console.WriteLine(person.GetName());
var student = new Student();
student.name = "Sirirungnapa";
System.Console.WriteLine(student.GetName());
 class Person
{
    public string? name;
    public string GetName()
    {
        return $"Hello from {name}";
    }
}
class Student : Person
{
    
}