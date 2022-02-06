using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class User
    {
        public int id { get; set; }
        public string user { get; set; }
        public int password { get; set; }

        [DataType(DataType.Date)]
        public DateTime birthday { get; set; }


    }
}
