using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace DotNetAppSqlDb.Models
{
    [Table("config")]
    public class Config
    {
        public int ID { get; set; }
        [Display(Name = "Pollrate")]
        public int Pollrate { get; set; }

        [Display(Name = "Postrate")]
        public int Postrate { get; set; }
    }
}