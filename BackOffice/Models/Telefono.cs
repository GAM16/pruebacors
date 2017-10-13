using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackOffice.Models
{
    public class Telefono
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}