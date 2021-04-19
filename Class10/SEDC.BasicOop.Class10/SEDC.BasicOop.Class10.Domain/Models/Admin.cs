using System;
using System.Collections.Generic;
using System.Text;
using SEDC.BasicOop.Class10.Domain.Enumerations;

namespace SEDC.BasicOop.Class10.Domain.Models
{
    public class Admin : User
    {
        public Admin() { }
        public Admin(int id, string fName,  string lName, string email, string password)
            : base(id, fName, lName, email, password, Role.Admin)
        {

        }

    }
}

