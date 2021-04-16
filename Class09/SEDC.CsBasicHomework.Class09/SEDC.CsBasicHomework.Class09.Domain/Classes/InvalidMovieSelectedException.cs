using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CsBasicHomework.Class09.Domain.Classes
{
    public class InvalidMovieSelectedException : Exception
    {
        public string Message { get; set; } = "Invalid movie selection";
    }
}
