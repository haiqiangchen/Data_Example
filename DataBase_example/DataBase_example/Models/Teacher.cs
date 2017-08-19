using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataBase_example.Models
{
    public class Teacher
    {
        //主键
        [Key]
        public int id { get; set; }
        //所带的学生
        public Student student { get; set; }
    }
}