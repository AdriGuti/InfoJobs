using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfoJobs.DataLayer
{
    public partial class Empresas
    {
        public Empresas()
        {
            Ofertas = new HashSet<Ofertas>();
        }

        public string Nombre { get; set; }
        public string Nif { get; set; }
        public string Sector { get; set; }
        public string Descripcion { get; set; }
        public string Contraseña { get; set; }

        public virtual ICollection<Ofertas> Ofertas { get; set; }
    }
}
