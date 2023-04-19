using System.Collections.Generic;

namespace SBMfotos.Models
{
    public class CadUsuarioViewModel
    {
        public ICollection<Produto> Livros { get; set; }
        public Usuario Usuario { get; set; }
    }
}