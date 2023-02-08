using CVNET.Data;
using CVNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CVNET
{
    public class IndexModel : PageModel
    {
        private readonly MeDbContext dbContext;
        public Me Robin = new Me();

        public IndexModel(MeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void OnGet()
        {
            Robin = dbContext._robin.Find(1);
            
        }
     

      
    }
    
}