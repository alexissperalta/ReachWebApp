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
        [Display(Name = "Poll rate")]
        public int Pollrate { get; set; }

        [Display(Name = "Post rate")]
        public int Postrate { get; set; }

        [Display(Name = "Real-time")]
        public int Realtime { get; set; }
    }
}