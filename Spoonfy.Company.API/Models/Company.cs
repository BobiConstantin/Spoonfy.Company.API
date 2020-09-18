using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spoonfy.Company.API.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Contact> ListOfContacts { get; set; }
    }
}