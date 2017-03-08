namespace swagtest.Models
{
  public class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    private string _fullName;

    public string FullName { get { return _fullName; } }

    public void SetFullName() 
    {
      _fullName = FullNameGenerator.GetFullName(FirstName, LastName);
    }
  }
}