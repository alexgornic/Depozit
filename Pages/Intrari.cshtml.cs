using Depozit.Domain.Models;
using Depozit.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Depozit.Pages
{
    public class IntrariModel : PageModel
    {
        private readonly IConfiguration conf;
        private readonly IIntrare intrariRepository;
        public List<Intrare> intrari;
        public IntrariModel(IConfiguration conf, IIntrare intrari)
        {
            this.conf = conf;
            this.intrariRepository = intrari;
        }

        public void OnGet()
        {
            var conString = conf.GetConnectionString("ConnectionString");
            this.intrari = intrariRepository.GetIntrari(conString);
        }
    }
}
