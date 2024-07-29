using System.Collections.Generic;
using BasicDataTemplateSample.Models;

namespace BasicDataTemplateSample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    /// <summary>
    /// As this is a list of Persons, we can add Students and Teachers here.
    /// </summary>
    public List<Person> People { get; } = new List<Person>
    {
        new Teacher
        {
            FirstName = "Mr.",
            LastName = "x",
            Age = 55,
            Sex=Sex.Diverse,
            Subject = "My Favorite Subject"
        }
    };
}
