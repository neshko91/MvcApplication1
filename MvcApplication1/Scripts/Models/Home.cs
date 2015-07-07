using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace MvcApplication1.Scripts.Models
{
    //za komentare
    //[Table("Komentar")]
    public class Home
    {
        public int IDKom{get;set;}
        public string Korisnicko_ime { get; set; }
        public DateTime Datum { get; set; }//tip DateTime
        public string Sadrzaj { get;set; }
        public int Br_plus { get; set; }
        public int Br_minus{get;set;}
          }
}