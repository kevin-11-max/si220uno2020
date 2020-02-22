

namespace webapiUno.Models
{
    using System.Data.Entity;

    public class DataContex:DbContext
    {
        public DataContex():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<webapiUno.Models.Person> People { get; set; }
    }
}