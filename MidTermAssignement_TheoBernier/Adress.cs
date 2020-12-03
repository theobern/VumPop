using System;
using System.Collections.Generic;
using System.Text;

namespace MidTermAssignement_TheoBernier
{
    class Adress
    {
        string nameStreet;
        string nameCity;
        string nameCountry;

        public string Street
        {
            get { return this.nameStreet; }
            set { this.nameStreet = value; }
        }

        public string City
        {
            get { return this.nameCity; }
            set { this.nameCity = value; }
        }

        public string Country
        {
            get { return this.nameCountry; }
            set { this.nameCountry = value; }
        }

        public Adress(string nameStreet, string nameCity, string nameCountry)
        {
            this.nameStreet = nameStreet;
            this.nameCity = nameCity;
            this.nameCountry = nameCountry;
        }

        public string FullAdress()
        {
            return this.nameStreet + ", " + this.nameCity + ", " + this.nameCountry;
        }
    }
}
