using System;
using System.Collections.Generic;
using System.Text;

namespace Composition3.Entitites
{
    class Client
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string eMail, DateTime birthDate)
        {
            Name = name;
            EMail = eMail;
            BirthDate = birthDate;
        }
    }
}
