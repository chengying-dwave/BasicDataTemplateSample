using System.Collections.Generic;
using BasicDataTemplateSample.Models;

namespace BasicDataTemplateSample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public List<Person> People { get; } = new List<Person>();
}
