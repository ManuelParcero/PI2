using System.Collections.Generic;
using System;


namespace SBMfotos.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public float Preco { get; set; } 
    }
}