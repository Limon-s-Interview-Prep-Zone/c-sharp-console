using System;
using System.Text;

namespace EncodingDecoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 14;
            Console.WriteLine($"The sum of {a} and {b} to={a + b} ");

            // string author = "Mahesh Chand";
            // // Convert a C# string to a byte array    
            // byte[] bytes = Encoding.ASCII.GetBytes(author);
            // foreach (byte b in bytes)
            // {
            //     Console.WriteLine(b);
            // }
            // // Convert a byte array to a C# string    
            // string str = Encoding.ASCII.GetString(bytes);
            // Console.WriteLine(str);
            // // Convert one Encoding type to another    
            // string authorName = "Here is a unicode characters string. Pi (\u03a0)";
            // // Create two different encodings.    
            // Encoding ascii = Encoding.ASCII;
            // Encoding unicode = Encoding.Unicode;
            // // Convert unicode string into a byte array.    
            // byte[] bytesInUni = unicode.GetBytes(authorName);
            // // Convert unicode to ascii    
            // byte[] bytesInAscii = Encoding.Convert(unicode, ascii, bytesInUni);
            // // Convert byte[] into a char[]    
            // char[] charsAscii = new char[ascii.GetCharCount(bytesInAscii, 0, bytesInAscii.Length)];
            // ascii.GetChars(bytesInAscii, 0, bytesInAscii.Length, charsAscii, 0);
            // // Convert char[] into a ascii string    
            // string asciiString = new string(charsAscii);
            // // Print unicode and ascii strings    
            // Console.WriteLine($"Author Name: {authorName}");
            // Console.WriteLine($"Ascii converted name: {asciiString}");
            // Console.ReadKey();
        }
    }
}
