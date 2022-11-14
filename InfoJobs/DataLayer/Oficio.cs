using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfoJobs.DataLayer
{
    public partial class Oficio
    {
        public Oficio()
        {
            Candidatos = new HashSet<Candidatos>();
            Ofertas = new HashSet<Ofertas>();
        }

        public int IdOficio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Candidatos> Candidatos { get; set; }
        public virtual ICollection<Ofertas> Ofertas { get; set; }
    }
}
