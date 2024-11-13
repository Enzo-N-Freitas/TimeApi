using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeApi.Models.Enums;

namespace TimeApi.Models
{
    public class Afazeres
    {
        public int Id { get; set; } 
        public string NomeAfazer { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataRegistro { get; set; }
        public DateTime? DataAfazer { get; set; }
        public TipodeAfazerEnum TipodeAfazer { get; set; }
    }
}