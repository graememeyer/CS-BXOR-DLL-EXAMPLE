using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CS_BXOR_DLL_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // First create a byte array from a string
            byte[] byteArray = Encoding.UTF8.GetBytes("This is a plaintext string.");
            Console.WriteLine("Initial string: " + Encoding.ASCII.GetString(byteArray));

            // Then encode the byte array using a provided byte key
            byte[] encodedByteArray = byteArray;
            BXORBytes(encodedByteArray, encodedByteArray.Length, 106);
            Console.WriteLine("Encoded string: " + Encoding.ASCII.GetString(encodedByteArray));

            // Finally, decode the byte array again with the same key,
            // demonstrating that the bitwise XOR operation is reversible.
            byte[] decodedByteArray = encodedByteArray;
            BXORBytes(decodedByteArray, decodedByteArray.Length, 106);
            Console.WriteLine("Decoded string: " + Encoding.ASCII.GetString(decodedByteArray));
        }

        // This DLL is available at https://github.com/graememeyer/BXOR-DLL
        [DllImport(".\\bin\\BXOR-DLL.dll")]
        public static extern void BXORBytes(
            [Out] byte[] byteArray, // The [out] attribute "marshals" the byteArray memory as writeable 
            int len,                // so that the C-compiled DLL can convert the byteArray object in-place
            byte key                // without causing a memory-access violation.
        );
    }
}
