
Student tural = new Student();
Console.WriteLine(tural.Age); 

Student suleyman = new Student();
Console.WriteLine(suleyman.Age); 

Student gafar = new Student();
Console.WriteLine(gafar.Age);

Student semed = new Student();
Console.WriteLine(semed.Age);

public class Student
{
    private static int _age = 0;
    public int Age { get; set; }
    public Student()
    {
        Age = ++_age;
    }
}

