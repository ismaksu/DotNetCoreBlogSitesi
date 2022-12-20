using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore5Kamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCommentController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());
        public IActionResult Index()
        {
            var values = cm.ListCommentWithBlog();
            return View(values);
        }
    }
}
