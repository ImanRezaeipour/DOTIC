using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace PTC.DOTIC.Web.Controllers
{
    public class HomeController : DOTICControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
