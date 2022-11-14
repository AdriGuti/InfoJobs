using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfoJobs.DataLayer
{
    public partial class Relacioncandidatosofertas
    {
        public string DniCandidato { get; set; }
        public int IdOferta { get; set; }

        public virtual Candidatos DniCandidatoNavigation { get; set; }
        public virtual Ofertas IdOfertaNavigation { get; set; }
    }
}
