using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SiteHualef.Models
{
    public class Context : DbContext
    {
        public Context()
            : base("Name=soxContext")
        {
            //this.Configuration.AutoDetectChangesEnabled = false;
            //this.Configuration.LazyLoadingEnabled = false;

            ///*
            //Obs: O conteúdo das linhas comentadas abaixo, recria o banco de dados de acordo com o que estiver mapeado e definido em MODELO
            //*/
            ////Database.SetInitializer<soxContext>
            ////    (new soxContextInitializer());

            Database.SetInitializer<Context>(null);
        }

        public DbSet<Show> show { get; set; }
        public DbSet<Fotos> fotos { get; set; }

    }
}