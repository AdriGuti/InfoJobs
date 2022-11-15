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

        public int IdOferta { get; set; }
        public string Titulo { get; set; }
        public string NifEmpresa { get; set; }
        public int IdOficio { get; set; }
        public string Descripcion { get; set; }

        public virtual Oficio IdOficioNavigation { get; set; }
        public virtual Empresas NifEmpresaNavigation { get; set; }
        public virtual ICollection<Relacioncandidatosofertas> Relacioncandidatosofertas { get; set; }
    }
}
