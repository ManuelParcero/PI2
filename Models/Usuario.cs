using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SBMfotos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string senha { get; set; }
        public string sexo { get; set; }
        public string Inscrito { get; set; }

    }
}