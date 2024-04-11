using System.Text;
using ConsoleApp1;

//1. What are the six combinations of access modifier keywords and what do they do? 
    //public - The type or member can be accessed by any other code in the same assembly or another assembly that references it.
    //private - The type or member can only be accessed by code in the same class or struct.
    //protected - The type or member can only be accessed by code in the same class or struct, or in a derived class.
    //internal - The type or member can be accessed by any code in the same assembly, but not from another assembly.
    //protected internal - The type or member can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly.
    //private protected - The type or member can only be accessed within its declaring assembly, by code in the same class or in a type that is derived from that class.

//2. What is the difference between the static, const, and readonly keywords when applied to a type member?
    //static - The static keyword is used to declare a static member, which belongs to the type itself rather than to a specific object. 
    //const - The const keyword is used to modify a declaration of a field or local variable. It specifies that the value of the field or the local variable is constant, which means it cannot be modified.
    //readonly - The readonly keyword is a modifier that you can use on fields. When a field declaration includes a readonly modifier, assignments to the fields introduced by the declaration can only occur as part of the declaration or in a constructor in the same class.
//3. What does a constructor do?
    //A constructor is a special method that is used to initialize objects. The constructor is called when an object of a class is created. It can be used to set initial values for fields, properties, and events.
//4. Why is the partial keyword useful?
    //The partial keyword is used to split a class, struct, or interface declaration into multiple parts. When a class is defined as partial, it can be split into multiple files. Each file contains a part of the class definition. All the parts are then combined into a single class when the application is compiled.
//5. What is a tuple?
    //A tuple is a data structure that is used to store a sequence of elements. The elements can be of different types. Tuples are useful when you want to return multiple values from a method without using out parameters.
//6. What does the C# record keyword do?
    //The record keyword is used to define a reference type that represents an immutable data structure. Records are similar to classes, but they are designed to be used for data transfer rather than behavior. Records are immutable, which means that their properties cannot be changed after they are set.
//7. What does overloading and overriding mean?
    //Overloading is a feature that allows you to define multiple methods with the same name but different parameters. Overloading is useful when you want to provide multiple ways to call a method with different parameters.
    //Overriding is a feature that allows you to provide a new implementation for a method that is defined in a base class. When you override a method, the new implementation is used instead of the original implementation. Overriding is useful when you want to provide a different implementation for a method in a derived class.
//8. What is the difference between a field and a property?
    //A field is a variable that is declared in a class or struct. Fields are used to store data that is associated with an object. Fields are accessed using the dot operator.
    //A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field. Properties are used to encapsulate the internal state of an object and provide a way to access and modify that state. Properties are accessed using the dot operator, just like fields.
//9. How do you make a method parameter optional?
    //You can make a method parameter optional by providing a default value for the parameter in the method signature. When you provide a default value for a parameter, the parameter becomes optional, and callers of the method can choose whether to provide a value for the parameter or use the default value.
//10. What is an interface and how is it different from abstract class?
    //An interface is a reference type that defines a contract for classes that implement it. An interface can contain methods, properties, events, and indexers, but it cannot contain fields, constructors, or destructors. An interface is used to define a set of members that a class must implement.
    //An abstract class is a class that cannot be instantiated directly. It is used as a base class for other classes that derive from it. An abstract class can contain abstract methods, which are methods that do not have an implementation. Abstract classes can also contain normal methods with an implementation. Abstract classes are used to define a common interface for a group of related classes.
//11. What accessibility level are members of an interface?
    //The members of an interface are always public. An interface defines a contract that must be implemented by classes that implement the interface. The members of the interface are public by default, which means that they can be accessed by any code that has a reference to the interface.
//12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.
    //True
//13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
    //True
//14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
    //False
//15. True/False. Abstract methods can be used in a normal (non-abstract) class. 
    //False
//16. True/False. Normal (non-abstract) methods can be used in an abstract class. 
    //True
//17. True/False.Derived classes can override methods that were virtual in the base class. 
    //True
//18. True/False.Derived classes can override methods that were abstract in the base class. 
    //True
//19. True/False.In a derived class, you can override a method that was neither virtual non abstract in the base class.
    //False
//20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.
    //False
//21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
    //True
//22. True/False. A class can have more than one base class.
    //False
//23. True/False. A class can implement more than one interface.
    //True


// 1. Reverse an Array

using System;
class ReverseArray
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(10);
        Console.WriteLine("Original array:");
        PrintNumbers(numbers);

        Reverse(numbers);
        Console.WriteLine("Reversed array:");
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }

    static void Reverse(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    static void PrintNumbers(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

// 2. Fibonacci Sequence
using System;

namespace ConsoleApp1;

public class FibonacciSeries
{
    public void Main()
    {
        //print first 10 items of Fibonacci series
        for (int i = 1; i <= 10; i++)
        {
            int fibonacciNumber = Fibonacci(i);
            Console.Write(fibonacciNumber+" ");
        }
        
        Console.WriteLine();
    }

    public int Fibonacci(int num)
    {
        if (num <= 2)
        {
            return 1;
        }
        else
        {
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}

//3. Person class
namespace ConsoleApp1;

using System;
using System.Collections.Generic;

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    IEnumerable<string> GetAddresses();
}

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    double CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    Department GetDepartment();
    void SetAsDepartmentHead();
}

public interface IDepartmentService
{
    Instructor GetDepartmentHead();
    decimal GetBudget();
    IEnumerable<Course> GetOfferedCourses();
}

public interface ICourseService
{
    IEnumerable<Student> GetEnrolledStudents();
    void EnrollStudent(Student student);
}

public abstract class Person
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<string> Addresses { get; set; }

    public Person()
    {
        Addresses = new List<string>();
    }

    public int CalculateAge()
    {
        var today = DateTime.Today;
        var age = today.Year - DateOfBirth.Year;
        if (DateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }

    public abstract decimal CalculateSalary();

    public IEnumerable<string> GetAddresses()
    {
        return Addresses;
    }
}

public class Student : Person, IStudentService
{
    private List<Course> _courses;
    private Dictionary<Course, char> _grades;

    public Student()
    {
        _courses = new List<Course>();
        _grades = new Dictionary<Course, char>();
    }

    public void EnrollInCourse(Course course)
    {
        _courses.Add(course);
        course.EnrollStudent(this);
    }

    public void SetGrade(Course course, char grade)
    {
        _grades[course] = grade;
    }

    public double CalculateGPA()
    {
        double totalPoints = 0;
        foreach (var grade in _grades.Values)
        {
            switch (grade)
            {
                case 'A':
                    totalPoints += 4;
                    break;
                case 'B':
                    totalPoints += 3;
                    break;
                case 'C':
                    totalPoints += 2;
                    break;
                case 'D':
                    totalPoints += 1;
                    break;
                default:
                    break;
            }
        }
        return totalPoints / _grades.Count;
    }

    public override decimal CalculateSalary()
    {
        return 0; // Students don't have a salary
    }
}

public class Instructor : Person, IInstructorService
{
    public DateTime JoinDate { get; set; }
    public Department Department { get; set; }
    public bool IsHeadOfDepartment { get; set; }

    public override decimal CalculateSalary()
    {
        decimal baseSalary = 50000;
        int yearsOfExperience = CalculateYearsOfExperience();
        decimal bonus = yearsOfExperience * 1000;
        return baseSalary + bonus;
    }

    public int CalculateYearsOfExperience()
    {
        return DateTime.Today.Year - JoinDate.Year;
    }

    public Department GetDepartment()
    {
        return Department;
    }

    public void SetAsDepartmentHead()
    {
        IsHeadOfDepartment = true;
    }
}

public class Department : IDepartmentService
{
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Course> OfferedCourses { get; set; }

    public Department()
    {
        OfferedCourses = new List<Course>();
    }

    public Instructor GetDepartmentHead()
    {
        return Head;
    }

    public decimal GetBudget()
    {
        return Budget;
    }

    public IEnumerable<Course> GetOfferedCourses()
    {
        return OfferedCourses;
    }
}

public class Course : ICourseService
{
    public string Name { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course()
    {
        EnrolledStudents = new List<Student>();
    }

    public IEnumerable<Student> GetEnrolledStudents()
    {
        return EnrolledStudents;
    }

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
    }
}