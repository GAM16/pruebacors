﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackOffice.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Telefono> Telefonos { get; set; }
    }
}