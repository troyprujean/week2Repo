using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personClass
{
    class Person1
    {
        
        string fname;
        string lname;
        double payrate;
        double taxrate;
        int accountnum;

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        public double Payrate
        {
            get
            {
                return payrate;
            }
            set
            {
                payrate = value;
            }
        }

        public double Taxrate
        {
            get
            {
                return taxrate;
            }
            set
            {
                taxrate = value;
            }
        }

        public int Accountnum
        {
            get
            {
                return accountnum;
            }
            set
            {
                accountnum = value;
            }
        }


        public Person1(string _fname, string _lname, double _payrate, double _taxrate, int _accountnum) //constructor class to set the class properties through the getters and setters via the paramaters of constructor
        {
            Fname = _fname;
            Lname = _lname;
            Payrate = _payrate;
            Taxrate = _taxrate;
            Accountnum = _accountnum;
        }
    }
}
