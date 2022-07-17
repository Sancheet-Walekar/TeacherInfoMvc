using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeacherInfoMvc.Models
{
    public class Teacher
    {
        public virtual int TeacherId
        { get; set; }

        public virtual String TeacherName
        { get; set; }

        public virtual String TeacherQual
        { get; set; }

        public virtual int YearsOfExp
        { get; set; }
    }
}