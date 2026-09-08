namespace OOPIntro;

public class ExerciseOopPropertiesPerson
{
    private string _firstName {get; set; }
    private string _lastName {get; set; }
    // private string FullName {get{return _firstName + " " + _lastName;}}
    private string FullName => _firstName + " " + _lastName;

    public ExerciseOopPropertiesPerson(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string GetFullName()
    {
        return FullName;
    }
    
}

