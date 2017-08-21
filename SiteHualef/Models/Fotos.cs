using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SiteHualef.Models
{
    public class Fotos
    {
        public int idFoto { get; set; }

        public string nome { get; set; }

        public int idShow { get; set; }

        public int tam { get; set; }

        //Definindo as chaves estrangeiras (ligações) da tabela
        [ForeignKey("idShow")]
        public virtual Show show { get; set; }
    }
}