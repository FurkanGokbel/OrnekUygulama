﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OrnekUygulama.Models
{
    public class KategoriGuncelleModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı gerekli")]
        public string Ad { get; set; }
       
    }
}
