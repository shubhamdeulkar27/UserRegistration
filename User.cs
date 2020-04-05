using System;

/// <summary>
/// User class to set and get data.
/// </summary>
public class User
{
    string firstName;
    string lastName;
    string email;
    string mobileNumber;
    string password;

    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string Email { get => email; set => email = value; }
    public string MobileNumber { get => mobileNumber; set => mobileNumber = value; }
    public string Password { get => password; set => password = value; }
}
