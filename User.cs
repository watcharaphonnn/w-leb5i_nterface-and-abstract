using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_LAB5
{
    public class User
    {
        protected string firstname;
        protected string lastname;
        protected string email;
        protected string phone;

        public void SetBasicInfo(string fname, string lname, string mail, string tel)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.email = mail;
            this.phone = tel;
        }

        public virtual string GetFullName() => $"{firstname} {lastname}";
    }
}