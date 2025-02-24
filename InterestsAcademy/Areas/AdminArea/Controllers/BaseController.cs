using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InterestsAcademy.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Route("/AdminArea/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class BaseController : Controller
    {


    }
}
