using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderBot_One.Components
{
    internal class A
    {
        public static string a(string a3)
        {
            char[] a1 = { '1', '1', (char)('0' + 4), (char)('3' + 2), '1', (char)('1' + 3) };
            char[] a2 = new char[a3.Length];

            for (int i = 0; i < a3.Length; i++)
            {
                a2[i] = (char)(a3[i] ^ a1[i % a1.Length]);
            }

            return new string(a2);
        }
    }
}
