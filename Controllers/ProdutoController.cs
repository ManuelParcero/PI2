using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SBMfotos.Models;


namespace SBMfotos.Controllers 
{
    public class ProdutoController : Controller
    {
        public IActionResult Fotos_digitais()
        {
            return View();
        }

        public IActionResult Impressoes()
        {
            return View();
        }

         public IActionResult Quebra_cabecas()
        {
            return View();
        }

         public IActionResult Cartoes_Postais()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

         [HttpPost]
        public IActionResult Cadastro(Produto p)
        {
            ProdutoService produtoService = new ProdutoService();

            if(p.Id == 0)
            {
                produtoService.Inserir(p);
            }
            else
            {
                produtoService.Atualizar(p);
            }

            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem(string tipoFiltro, string filtro)
        {
            Autenticacao.CheckLogin(this);
            FiltrosProduto objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosProduto();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            ProdutoService livroService = new ProdutoService();
            return View(livroService.ListarTodos(objFiltro));
        }

        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this);
            ProdutoService ls = new ProdutoService();
            Produto l = ls.ObterPorId(id);
            return View(l);
        }










    }
}