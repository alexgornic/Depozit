using Depozit.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Depozit.Pages
{
    public class DeleteIntrareModel : PageModel
    {
        private IConfiguration conf;
        private IIntrare iRepository;

        public DeleteIntrareModel(IConfiguration conf, IIntrare iRepository)
        {
            this.conf = conf;  
            this.iRepository = iRepository;
        }
        public void OnGet()
        {
            int id = int.Parse(Request.Query["id"]);
            string conString = conf.GetConnectionString("ConnectionString");
            iRepository.DeleteIntrare(conString, id);

            Response.Redirect("/Intrari");

        }
    }
}
