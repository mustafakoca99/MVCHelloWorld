using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcControllerScaffHold.Models
{
    public class kitap
    {
        public string adi { get; set; }
        [Required(ErrorMessage = "Ad gereklidir.")]
        public string yazar { get; set; }
        [Required(ErrorMessage = "yazar gereklidir.")]
        public int sayfasayisi { get; set; }
        public string yayinevi { get; set; }
        //  [Required(ErrorMessage = "yayinevi gereklidir.")]
        
    }
}