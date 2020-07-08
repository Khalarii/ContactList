using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    class Program
    {
        /// <summary>
        /// Simple program to create a list of contacts that can be searched.
        /// Extremely fast search function.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var contacts = new Contacts();
            var log = new ExceptionLog();
            
            try
            {
                List<string> randomNames = new List<string>
                {
                    "John", "Jane", "Mary Ellen", "laskjdhfalksdjfhasdlkfjhsadlkfjhasdlkfjsadhflkasdjhflaksdjfhasdkljfh", "", null, "Larry",
                    //Large string
                    "".PadLeft(10000, 'a')
                };

                string[] searchParameters = new string[]
                {
                    "a", "aaaaaaaaaaaaaaaaaaaaaaaa", "J", "lasd", "lask", "L", "Harry", "Mary ", null, ""
                };

                foreach (var name in randomNames)
                {
                    contacts.AddContact(name);
                }

                foreach (var parameter in searchParameters)
                {
                    Console.WriteLine(string.Format("Contacts starting with '{0}': {1}", parameter, string.Join(", ", contacts.FindContacts(parameter))));
                }
            }
            catch(ArgumentNullException nullException)
            {
                log.LogException(nullException);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
