using System.Collections.Generic;

namespace SiteJson.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string Layout { get; set; }
        public string Title { get; set; }
        public string PageTitle { get; set; }
        public string Favicon { get; set; }
        public string Keywords { get; set; }
        public string Desciption { get; set; }
        public string Logo { get; set; }
        public string LogoOG { get; set; }
        public List<Content> Conteudo { get; set; } = new List<Content>();
        public List<Pagina> Paginas { get; set; } = new List<Pagina>();
    }
}
