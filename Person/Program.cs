
using System;

class Program
{
    static void Main()
    {
        try
        {
            PersonHandler personHandler = new PersonHandler();
            Person person1 = personHandler.CreatePerson(35, "Mohammad", "Kassar", 180, 75);

            Console.WriteLine($"NAME: {person1.FName} {person1.LName} AGE: {person1.Age} HEIGHT: {person1.Height} WEIGHT: {person1.Weight}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
public class Person
{
    private int age;
    private string fname;
    private string lname;
    private double height;
    private double weight;

    public int Age { 
        get { return age; } 
        set
        { 
        if (value <= 0)
            {
                throw new ArgumentException("Age should not be less than 1.");
            }
        age = value;
        }
    }
   public string FName
    {
        get { return fname; }
        set {
            if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10)
            {
                throw new ArgumentException("First name should be betwenn 2 and 10 char");
            }
            fname = value;
        }
    }
    public string LName
    {
        get { return lname; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15)
            {
                throw new ArgumentException("Last name should be between 3 and 15 char");
            }
            lname = value;
        }
    }
    public double Height
    { get { return height; } set { height = value; } }
    public double Weight 
    { get { return weight; } set { weight = value; } }
}
public class PersonHandler
{
    public void SetAge (Person pers, int age)
    {
        pers.Age = age;
    }
    public Person CreatePerson (int age, string fname, string lname, double height, double weight)
    {
        Person newPerson = new Person
        {
            Age = age,
            FName = fname,
            LName = lname,
            Height = height,
            Weight = weight,
        };
        return newPerson;
    }
}