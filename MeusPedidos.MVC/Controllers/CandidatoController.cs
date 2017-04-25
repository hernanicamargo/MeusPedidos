using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeusPedidos.Infra.Data.Repositories;
using MeusPedidos.MVC.ViewModels;

namespace MeusPedidos.MVC.Controllers
{
    public class CandidatoController : Controller
    {
        private readonly CandidatoRepository _candidatoRepository = new CandidatoRepository();
        
        // GET: Candidato
        public ActionResult Index()
        {            
            return View();
        }

        // POST: Candidato/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}
