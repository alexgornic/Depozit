using Depozit.Domain.Models;
using Depozit.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Depozit.Pages
{
    public class UpdateIntrareModel : PageModel
    {
        private IConfiguration conf;
        private IIntrare iRepository;
        public Intrare intrare { get; set; }    

        public UpdateIntrareModel(IConfiguration conf, IIntrare iRepository)
        {
            this.conf = conf;
            this.iRepository = iRepository; 
        }
        public void OnGet()
        {
            var id = int.Parse(Request.Query["id"]);
            var conString = conf.GetConnectionString("ConnectionString");
            this.intrare = iRepository.GetIntrare(conString, id);
        }

        public void OnPost()
        {
            var id = int.Parse(Request.Form["id"]);
            var conString = conf.GetConnectionString("ConnectionString");
            iRepository.UpdateIntrare(conString, id, Request.Form["productName"],
                Request.Form["partnerName"], int.Parse(Request.Form["quantity"]));
            this.OnGet();   

            Response.Redirect("/Intrari");
        }
    }
}
