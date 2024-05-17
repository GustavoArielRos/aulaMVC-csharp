using MeuSiteEmMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeuSiteEmMVC.Controllers
{
    public class HomeController : Controller
    {
        
        //m�todo que ativa a p�gina principal
        public IActionResult Index()
        {
            HomeModel home = new HomeModel();//Criei um objeto do tipo "HomeModel"

            //adicionando informa��es no objeto "home" criado
            home.Nome = "Acaciano Neves";
            home.Email = "acaciano.neves@gmail.com";

            return View(home);//dessa forma a VIEW interage com a MODEL(perceba que estamos no CONTROLER)
        }
        //m�todo que ativa a p�gina de privacidade
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //m�todo que ativa a p�gina de erro
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
