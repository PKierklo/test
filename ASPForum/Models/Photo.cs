﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPForum.Models
{
    public class Photo
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string Title { get; set; }
        public string Text { get; set; }
        public string Source { get; set; }
        public int ThreadId { get; set; }
        public virtual Thread Thread { get; set; }

    }
}