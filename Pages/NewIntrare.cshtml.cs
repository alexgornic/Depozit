using Depozit.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Depozit.Pages
{
    public class NewIntrareModel : PageModel
    {
        private IConfiguration conf;
        private IIntrare intrareRepository;

        public NewIntrareModel(IConfiguration conf, IIntrare intrareRepository)
        { 
           this.conf = conf;   
           this.intrareRepository = intrareRepository;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            var conString = conf.GetConnectionString("ConnectionString");
            intrareRepository.CreateIntrare(conString, Request.Form["productName"], 
                Request.Form["partnerName"], int.Parse(Request.Form["quantity"]));

            Response.Redirect("/Intrari");
        }
    }
}
