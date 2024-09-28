using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject
{
    public class Person
    { 

        #region data members
        private string name, lastName, Phone, email;
        #endregion

        #region Properties
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Telephone
        {
            get { return Phone; }
            set { Phone = value; }
        }
        #endregion

        #region Construtor
        public Person()
        {   
            lastName = "";
            name = "";
            Phone = "";
            email = "";

        }

        public Person(string pName, string lastName, string pPhone, string email)
        {
            
            name = pName;
            Phone = pPhone;
            this.lastName = lastName;
            this.email = email;
        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n'+ lastName + '\n' + Phone + '\n' + email;
        }

        #endregion
    }
}
