using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject.Business
{
    public class Child:Person
    {
        #region Fields
        private int Age;
        private double TotalCost;
        #endregion
        #region Properties
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public double totalCost
        {
            get { return TotalCost; }
            set { TotalCost = value; }
        }
        #endregion

        #region Contructors
        public Child():base() {
            age = -1;
            totalCost = -1;
        }
        public Child(string name, string lastName, string phone, string email, int age, double totalCost):base(name, lastName, phone, email) { 
            this.Age = age;
            this.TotalCost = totalCost;
        }
        #endregion

    }
}
