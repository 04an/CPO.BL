using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acm.Common
{
    public class StringHandler
    {
        public string InsertSpace(string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result += " ";
                    }
                    result += letter;
                }
            }
            return result;
        }
    }
}
