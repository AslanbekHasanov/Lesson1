namespace Lesson1
{
  public class User
  {
    public User
    (
      string firstName,
      int age,
      string email
    )
    {
      this.FirstName = firstName;
      this.Age = age;
      this.Email = email;
    }
    public string? FirstName { get; set; }
    public int Age { get; set; }
    public string? Email { get; set; }


  }
}