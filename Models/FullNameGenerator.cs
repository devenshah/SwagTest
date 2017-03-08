namespace swagtest.Models
{
    public class FullNameGenerator
    {
      public static string GetFullName(string firstName, string lastName)
      {
        return $"{firstName} {lastName}";
      }
    }
}