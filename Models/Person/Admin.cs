using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoviESWeb.Models.Person
{
    class Admin : Person
    {
        private bool godMode;

        public Admin(int id, string name, string email, string password) :
               this(id, name, email, password, true)
        { }

        public Admin(int id, string name, string email, string password, bool godMode) : base(id, name, email, password)
        {
            this.godMode = godMode;

        }

        public bool GodMode { get => godMode; set => godMode = value; }
    }
}
