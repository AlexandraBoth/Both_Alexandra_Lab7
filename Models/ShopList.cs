using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Both_Alexandra_Lab7.Models
{


    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }

}
