using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes8523.Services
{
    public class Customer
    {
        string _name;
        string _surname;

        string _creditCardNo;
        public string CreditCardNo 
        { 
            get
            {
                return "**** **** **** " + _creditCardNo.Substring(15);
            }
            set
            {
                _creditCardNo = value;
            }
        }

        public bool ErkekMi { get; set; }

        public string Cinsiyet
        {
            get
            {
                //return ErkekMi ? "Erkek" : "Kadın";
                if (ErkekMi)
                {
                    return "Erkek";
                }
                else
                {
                    return "Kadın";
                }
            }
        }

        public string TitleNameSurname => ErkekMi ? "Mr " + _name + " " + _surname : "Ms " + _name + " " + _surname;

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetSurname(string surname)
        {
            _surname = surname;
        }
        public string GetSurname()
        {
            return _surname;
        }

        public void DisplayNameSurname()
        {

        }
    }
}
