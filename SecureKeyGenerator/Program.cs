// Generate a 256-bit random key
using System.Security.Cryptography;

byte[] keyBytes = new byte[32]; // 256 bits = 32 bytes
using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
{
    rng.GetBytes(keyBytes);
}

// Convert the byte array to a base64-encoded string
string base64Key = Convert.ToBase64String(keyBytes);

Console.WriteLine("Generated Key: " + base64Key);