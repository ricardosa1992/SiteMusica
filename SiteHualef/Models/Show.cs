﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteHualef.Models
{
    public class Show
    {
        public int idShow { get; set; }

        public DateTime data { get; set; }

        public string rua { get; set; }

        public string cidade { get; set; }

        public int qtdPessoas { get; set; }
    }
}