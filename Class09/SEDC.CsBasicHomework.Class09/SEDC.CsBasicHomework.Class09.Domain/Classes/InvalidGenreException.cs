using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CsBasicHomework.Class09.Domain.Classes
{
    public class InvalidGenreException : Exception
    {
        public string Message { get; set; } = "Invalid genre exception";
    }
}
