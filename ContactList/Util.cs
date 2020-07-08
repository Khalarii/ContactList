using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public static class Util
    {
        /// <summary>
        /// Returns all possible strings from the beginning of the input value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>List of all possible substrings starting from index 0.</returns>
        public static List<string> GetAllSubstringsFromStart(string value)
        {
            List<string> output = new List<string>();

            //Check for null and empty strings
            if (value?.Any() ?? false)
            {
                for (int i = 1; i <= value.Length; i++)
                {
                    output.Add(value.Substring(0, i));
                }
            }

            return output;
        }
    }
}
