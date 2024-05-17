using MeuSiteEmMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeuSiteEmMVC.Controllers
{
    public class HomeController : Controller
    {
        
        //método que ativa a página principal
        public IActionResult Index()
        {
            HomeModel home = new HomeModel();//Criei um objeto do tipo "HomeModel"

            //adicionando informações no objeto "home" criado
            home.Nome = "Acaciano Neves";
            home.Email = "acaciano.neves@gmail.com";

            return View(home);//dessa forma a VIEW interage com a MODEL(perceba que estamos no CONTROLER)
        }
        //método que ativa a página de privacidade
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //método que ativa a página de erro
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
