using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfoJobs.DataLayer
{
    public partial class Ofertas
    {
        public Ofertas()
        {
            Relacioncandidatosofertas = new HashSet<Relacioncandidatosofertas>();
        }

        public int Idoferta { get; set; }
        public string Titulo { get; set; }
        public string NifEmpresa { get; set; }
        public int Idoficio { get; set; }
        public string Descripcion { get; set; }

        public virtual Oficio IdoficioNavigation { get; set; }
        public virtual Empresas NifEmpresaNavigation { get; set; }
        public virtual ICollection<Relacioncandidatosofertas> Relacioncandidatosofertas { get; set; }
    }
}
