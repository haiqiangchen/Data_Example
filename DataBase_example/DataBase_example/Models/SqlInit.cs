using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBase_example.Models
{
    public class SqlInit
    {
        DataMaintain dataMaintain = new DataMaintain();
        public SqlInit() {
            dataMaintain.students.Add(new Student { number="20143029",name="小明",age="12",sex="男",adress="微软小学"});
            dataMaintain.students.Add(new Student { number = "20143028",name = "小黄", age = "12", sex = "男", adress = "微软小学" });
            dataMaintain.students.Add(new Student { number = "20143027",name = "小清", age = "12", sex = "男", adress = "微软小学" });
            dataMaintain.teacher.Add(new Teacher { student= new Student { number = "20143027", name = "小清", age = "12", sex = "男", adress = "微软小学" } });
            dataMaintain.SaveChanges();
        }
    }
}