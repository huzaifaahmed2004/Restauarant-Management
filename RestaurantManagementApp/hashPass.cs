using System.Security.Cryptography;
using System.Text;

public static class hashPass
{
    public static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            // Convert the password to a byte array and hash it
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Convert the byte array to a hexadecimal string
            StringBuilder hashStringBuilder = new StringBuilder();
            foreach (byte byteValue in hashBytes)
            {
                hashStringBuilder.Append(byteValue.ToString("x2"));
            }

            return hashStringBuilder.ToString();
        }
    }
}
