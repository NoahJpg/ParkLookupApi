namespace CretaceousApi.Models
{
  public class UserModel
  {
    public string Username { get; internal set; }
    public string Password { get; internal set; }
    public string GivenName { get; internal set; }
    public string Surname { get; internal set; }   
    public string EmailAddress { get; internal set; }
    public string Role { get; internal set; }
    
  }
}