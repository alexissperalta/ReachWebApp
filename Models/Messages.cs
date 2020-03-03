﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetAppSqlDb.Models
{
    [Table("messages")]
    public class Messages
    {
        [Key]
        [Display(Name = "Message")]
        public string Msg { get; set; }

        public string Rec_time { get; set; }
    }
}