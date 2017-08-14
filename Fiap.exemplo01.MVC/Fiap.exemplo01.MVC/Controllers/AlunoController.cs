using Fiap.exemplo01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.exemplo01.MVC.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno

       //Action para adbrir o formulario
       [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        //Action para cadastrar as informação do formulario
        [HttpPost]
        public ActionResult Salvar(Aluno aluno)
        {

            // return Content("gravou !" + aluno.Nome + " " + aluno.Data + " " +  aluno.Salario); //texto

            //retornando da controler para tela
            ViewBag.nomeAluno = aluno.Nome;
            ViewBag.dataAluno = aluno.Data;
            ViewBag.salarioAluno = aluno.Salario;
            TempData["mensagem"] = "Aluno registrado";
            return View(aluno);
        }

    }
}