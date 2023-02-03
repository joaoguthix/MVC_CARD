using System;
using System.ComponentModel.DataAnnotations;

namespace Card.Models
{
    public class NCard
    {
        
        public int Id { get; set; }
       
        public string TitleName { get; set; }

        public string CardNumber { get; set; }

        public string Expiration { get; set; }

        public string CVC { get; set; }

        public bool Done { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}