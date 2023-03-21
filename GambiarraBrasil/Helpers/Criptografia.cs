using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace GambiarraBrasil.Helpers {
    public static class Criptografia {
        public static string GerarHash(this string value) {
            var hash = SHA1.Create();
            var encd = new ASCIIEncoding();
            var array = encd.GetBytes(value);
            
            array = hash.ComputeHash(array);

            var senhaCriptografada = new StringBuilder();

            foreach (var item in array) {
                senhaCriptografada.Append(item.ToString("x2"));
            }
            return senhaCriptografada.ToString();
        }
    }
}
