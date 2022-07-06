using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SiteJson.Data;
using SiteJson.Models;
using System.Linq;

namespace SiteJson.Controllers
{
    public class PaginaController : Controller
    {
        private readonly Site _site;
        private readonly IConfiguration _configuration;

        public PaginaController(IConfiguration configuration)
        {
            _site = Context.Site;
            _configuration = configuration;
        }


        public IActionResult Index(string slug)
        {
            var pagina = _site.Paginas.FirstOrDefault(x => x.Slug == slug);
            return View(pagina);
        }
    }
}
