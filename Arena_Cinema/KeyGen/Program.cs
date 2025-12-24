using System;
using System.Security.Cryptography;
using System.Text;

namespace KeyGen
{
    internal class Program
    {
        // PRIVATE KEY: chỉ để trong tool KeyGen, KHÔNG nhúng vào app
        private const string RSA_PRIVATE_KEY_XML = @"<RSAKeyValue><Modulus>xsNnGI5LhzcDT6u802aqJazQRw1I0tcRTQL2xR0mTctCMzwlsNjK8S+1SF7O5/7S9N1NqhoCK6E3neDfDZYNg05CjhENYOHMrGjBZoOalMUtq41l0cIr99t3Y4Z5YfesFON0GzU4om8lU7wRdfSlc37dzmXSfLHNCM1ITMXNip+RnZxiAwsbndlGKhQLTDgaRzQFmZE4uMP4+VYUS57FQbVVOs/B6NETzqYP0zuHNKRSGpHD3PgfymeyvXcJc94fer0Ac4ylq5xOFoSpXTAhyOg7Crej7UCIn9MYetEISUMO2fZOlyAGPXKQV5YeccasmtYmDtwlZ35R8VbtaWGBTQ==</Modulus><Exponent>AQAB</Exponent><P>zJ5aishfIxoUcrWpOB5fcABy9gV/aH5HwX8aGd/2cVuVK/fjEJy5CwE2r2GkV9daIOSoYW+lBbGv0t8RQuKk8/SaEFvmZ+rTcOZPP6FfU1ViO5dM+r/Pkdzr+jVcA7diuXqbl0xEmZ0q0bn2OT4nK9O5hzluOxc145RNKQtDCYs=</P><Q>+KymYlSWSr1saS3aYuNlHgphK6uSzSoN3PNVM8/FB600KuuD7XaSzBHHCCdMd2fKA60i/UdZSVXrlfzPhL5DjkksfzNFkyF91/Jneaki7dmHuTZCjb+047a75MkZeDWd/VXTaBx17fW53aWZH9luK6K0Euhg7TxYSJwJw3mri4c=</Q><DP>ozmC8oiKU97/Bs5hEbIw4ZCKJDUYgIuTxAgXEyL0XVL4OR3CFUNf3SZ3sAnM5oGUlP6yTx+XXWZz4lwtUdSoTy8FIx2cO7M4PiyKdTDOcRSAixbTwob2Ft5Lo8mjABfu+hSTP2sIoh2cxbZ5cwpghvabXgJzK1IFm+h2cNJaBKc=</DP><DQ>bF9Jj5bPfLj6kwfhobD581KQsGhwbKsEKaN+ITtN4Z+RGZdUAlvnc7nXpG0D/RGlT17X3cuHVNd1+QKZKX+Fj2/CTZj5nDo/TqocgD++sitX49aKwJ2oZojPb9BYIjQzqyEJJdkpZ8/r9XViuyeVxLx+f7L38suWqeYetyrCIOc=</DQ><InverseQ>fW0BvFNUYLfIK2d8dcWU702Jk5gJj2u83ixzvFpGcOLRTr0S5hWKsqF/zd5AVWTeCqRMRpYrCXRYgi5f9/YU3g0YCAuQu+NUPzYJGX7Yh4zOhLCJiTml8H+Qffq5enRTzyrxk2Kkrt5N+hKa7dSVc7sT1PeTZJjWU7X2CAI1Jik=</InverseQ><D>pUGnwRHmGBkURrR6PaX5R3PEg5628p3gA5C4TbDrvPiHJQQYLk5BhYBuECrLirYi/XXWcdxH+7CCBmEF80zUFV0HFwl0fx2dx6cdTbeT2aeLTjw08M6pMd2mCPiwiVScHY3zZf+9A8i3V0RhnBn5SeqsTkP4WraVy4CqYTKAr4R9ch1Qd1CE+Alg6ySCSFSDv1rWqeKYUJv/5nOPo+K66ATGpjQzxp6NnVTde39eLd8RfMu/I3DuMlgaAValidmujxYzTJ5WnjSIuhc0SMOKn157VbO4AmfByndRx2Ryce6zNdDrc57tTq7B4lX21gN4T9ogpMoMzPv419vB4i7u3Q==</D></RSAKeyValue>";

        static void Main(string[] args)
        {
            string installId;

            if (args.Length >= 1)
            {
                installId = args[0].Trim();
            }
            else
            {
                Console.Write("InstallId: ");
                installId = (Console.ReadLine() ?? "").Trim();
            }

            if (string.IsNullOrWhiteSpace(installId))
            {
                Console.WriteLine("InstallId rỗng.");
                return;
            }

            byte[] payload = Encoding.UTF8.GetBytes(installId);

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(RSA_PRIVATE_KEY_XML);

                // Phải đồng bộ với Verify bên app: SHA256
                byte[] signature = rsa.SignData(payload, CryptoConfig.MapNameToOID("SHA256"));

                string activationKey = Convert.ToBase64String(signature);

                Console.WriteLine("Activation Key (Base64):");
                Console.WriteLine(activationKey);
            }
        }
    }
}
