namespace FitShirt.Domain.Security.Services;

public interface IEncryptService
{
    string Encrypt(string value);
    bool Verify(string password, string passwordHashed);
}