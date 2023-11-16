using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoviESWeb.Models.Person
{
    class User : Person
    {
        private string monthlyPlan;
        private int numOfProfiles;
        private bool parentControl;

        public User(int id, string name, string email, string password) :
               this(id, name, email, password, "Standard", 1, false)
        { }

        public User(int id, string name, string email, string password, string monthlyPlan, int numProfiles, bool parentControl) : base(id, name, email, password)
        {
            this.monthlyPlan = monthlyPlan;
            numOfProfiles = numProfiles;
            this.parentControl = parentControl;

        }

        public string MonthlyPlan { get => monthlyPlan; set => monthlyPlan = value; }
        public int NumOfProfiles { get => numOfProfiles; set => numOfProfiles = value; }
        public bool ParentControl { get => parentControl; set => parentControl = value; }
    }
}
