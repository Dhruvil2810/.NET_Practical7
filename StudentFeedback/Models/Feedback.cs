using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentFeedback.Models
{
    public class Feedback
    {
        public int EnrollmentNumber { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }

        public int Rating { get; set; }
        public string Comment { get; set; }

    }
}