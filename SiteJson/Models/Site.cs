using System.Collections.Generic;

namespace SiteJson.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string Css { get; set; }
        public List<Pagina> Paginas { get; set; } = new List<Pagina>();
    }
}
