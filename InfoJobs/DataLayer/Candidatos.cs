using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfoJobs.DataLayer
{
    public partial class Candidatos
    {
        public Candidatos()
        {
            Relacioncandidatosofertas = new HashSet<Relacioncandidatosofertas>();
        }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dni { get; set; }
        public int IdOficio { get; set; }
        public string Contraseña { get; set; }

        public virtual Oficio IdOficioNavigation { get; set; }
        public virtual ICollection<Relacioncandidatosofertas> Relacioncandidatosofertas { get; set; }
    }
}
