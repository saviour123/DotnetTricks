using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SECIDENT4.AuthProvider.Controllers
{
    [Route("details")]
    [Authorize]
    public class DetailsController : ControllerBase
    {
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value});
        }
    }
}