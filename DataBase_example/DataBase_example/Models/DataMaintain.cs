using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace DataBase_example.Models
{
    public class DataMaintain:DbContext
    {
        public DataMaintain() {
            Database.SetInitializer<DataMaintain>(new DropCreateDatabaseAlways<DataMaintain>());//清空数据库
        }
        public DbSet<Student> students { set; get; }
        public DbSet<Teacher> teacher { set; get; }
    }
}