using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SBMfotos.Models;
using Microsoft.EntityFrameworkCore;

namespace SBMfotos.Controllers
{
    public class UsuarioController: Controller
    
    {
        public IActionResult Cadastro()
        {
            UsuarioService usuarioservice = new UsuarioService();
            UsuarioService usuarioService = new UsuarioService();

            CadUsuarioViewModel cadModel = new CadUsuarioViewModel();
            cadModel.Usuario = usuarioService.ListarTodos();
            return View(cadModel);
        }

        [HttpPost]
        public IActionResult Cadastro(CadUsuarioViewModel viewModel)
        {
            UsuarioService usuarioService = new UsuarioService();
            
            if(viewModel.Usuario.Id == 0)
            {
                usuarioService.Inserir(viewModel.Usuario);
            }
            else
            {
                usuarioService.Atualizar(viewModel.Usuario);
            }
            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem(string tipoFiltro, string filtro)
        {
            FiltrosUsuario objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosUsuario();
                objFiltro.filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            UsuarioService emprestimoService = new UsuarioService();
            return View(emprestimoService.ListarTodos(objFiltro));
        }
         public IActionResult Listagem(string tipoFiltro, string filtro)
        {
            FiltrosUsuario objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosUsuario();
                objFiltro.filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            UsuarioService emprestimoService = new UsuarioService();
            return View(emprestimoService.ListarTodos(objFiltro));
        }

        public IActionResult Edicao(int id)
        {
            UsuarioService usuarioservice = new UsuarioService();
            UsuarioService us = new UsuarioService();
            Usuario u = us.ObterPorId(id);

            CadUsuarioViewModel cadModel = new CadUsuarioViewModel();
            cadModel.Usuario = usuarioservice.ListarTodos();
            cadModel.Usuario = u;
            
            return View(cadModel);
        }
    }
}