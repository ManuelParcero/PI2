using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace SBMfotos.Models
{
    public class ProdutoService
    { 
         public void Inserir(Produto P)
        {
            using(SBMfotosContext bc = new SBMfotosContext())
            {
                bc.Produto.Add(P);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Produto P)
        {
            using(SBMfotosContext bc = new SBMfotosContext())
            {
                Produto Produto = bc.Produto.Find(P.Id);
                Produto.Nome = P.Nome;
                Produto.Tipo = P.Tipo;

                bc.SaveChanges();
            }
        }

        public ICollection<Produto> ListarTodos(FiltrosProduto filtro = null)
        {
            using(SBMfotosContext bc = new SBMfotosContext())
            {
                IQueryable<Produto> query;
                
                if(filtro != null)
                {
                    //definindo dinamicamente a filtragem
                    switch(filtro.TipoFiltro)
                    {
                        case "Nome":
                            query = bc.Produto.Where(P => P.Nome.Contains(filtro.Filtro));
                        break;

                        case "Titulo":
                            query = bc.Produto.Where(P => P.Tipo.Contains(filtro.Filtro));
                        break;

                        default:
                            query = bc.Produto;
                        break;
                    }
                }
                else
                {
                    // caso filtro não tenha sido informado
                    query = bc.Produto;
                }
                
                //ordenação padrão
                return query.OrderBy(P => P.Tipo).ToList();
            }
        }

    

        public Produto ObterPorId(int id)
        {
            using(SBMfotosContext bc = new SBMfotosContext())
            {
                return bc.Produto.Find(id);
            }
        }
        
    }
}