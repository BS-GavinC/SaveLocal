using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonWriteDoc
{
    internal class User
    {

        public string ID { get; set; }
        public string Name { get; set; }
        public string Pseudo { get; set; }

        public Adress addresse { get; set; }

        public User(string name, string pseudo)
        {
            ID = new Guid().ToString();
            Name = name;
            Pseudo = pseudo;
        }

    }
}
