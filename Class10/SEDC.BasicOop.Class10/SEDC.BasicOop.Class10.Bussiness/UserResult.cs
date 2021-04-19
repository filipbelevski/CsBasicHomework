using SEDC.BasicOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BasicOop.Class10.Bussiness
{
    public class UserResult
    {
        public Admin Admin { get; set; }
        public Student Student{ get; set; }
        public Trainer Trainer{ get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
