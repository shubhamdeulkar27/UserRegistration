/// <summary>
/// Interface Validate for validate functions
/// </summary>
interface IValidate
{
    void ValidateName(string firstName, string lastName);
    void ValidateEmail(string email);
    void ValidateMobileNumber(string mobileNumber);
    void ValidatePassword(string password);
}