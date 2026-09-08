// Create a class Person representing a person.

namespace OOPIntro;

public class ExerciseOopConstructorPerson
{
    private string _firstName { get; set; }
    private string _lastName  { get; set; }
    private int _age  { get; set; }

    public ExerciseOopConstructorPerson(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }
    
}