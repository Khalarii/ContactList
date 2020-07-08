using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class Contacts
    {
        /// <summary>
        /// Key of the dictionary is the searched substring.
        /// Value contains list of all contacts which apply to said search.
        /// </summary>
        private Dictionary<string, List<string>> _searchableContacts;
        //A dictionary was used here as it massively improves processing time even though it takes up more memory.
        //A solution that could be used here to minimize memory consumption would be Linq, though it would exponentially
        //increase processing time for large amounts of data.

        public Contacts()
        {
            _searchableContacts = new Dictionary<string, List<string>>();
        }

        public void AddContact(string contactName)
        {
            var substrings = Util.GetAllSubstringsFromStart(contactName);

            foreach (var sub in substrings)
            {
                //If a certain substring has already been registered, simply add the contact to the list of contacts that start with the substring.
                if (_searchableContacts.ContainsKey(sub))
                {
                    _searchableContacts[sub].Add(contactName);
                }
                else
                {
                    _searchableContacts.Add(sub, new List<string> { contactName });
                }
            }
        }

        /// <summary>
        /// Searches all registered contacts that start with the given string.
        /// </summary>
        /// <param name="partialName">Partial name to search.</param>
        /// <returns>List of contacts that start with the given string.</returns>
        public List<string> FindContacts(string partialName)
        {
            if ((partialName?.Any() ?? false) && _searchableContacts.ContainsKey(partialName))
            {
                return _searchableContacts[partialName];
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
