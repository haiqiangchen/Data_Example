using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataBase_example.Models
{
    public class Student
    {
        //主键
        [Key]
        public int id { get; set; }
        //学号
        public string number { get; set; }
        //姓名
        public string name { get; set; }
        //年龄
        public string age { get; set; }
        //性别
        public string sex { set; get; }
        //地址
        public string adress { set; get; }

    }
}