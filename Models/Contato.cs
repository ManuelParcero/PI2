using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SBMfotos.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [StringLength(156)]
        public string Nome { get; set; }

        [StringLength(156)]
        public string Email { get; set; }

         [StringLength(156)]
        public string Telefone { get; set; }

        [StringLength(512)]
        public string Mensagem { get; set; }
    }
}