using Microsoft.AspNetCore.Mvc;
using Villamor_Portfolio_Quiz.Models;


namespace Villamor_Portfolio_Quiz.Controllers
{
    public class CommentsController : Controller
    {
        [HttpPost]
        public IActionResult Add(
            string projectName,
            string actionName,
            string name,
            string text)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(text))
            {
                return RedirectToAction(actionName, "Projects");
            }

            CommentStore.Comments.Add(new Comment
            {
                ProjectName = projectName,
                Name = name,
                Text = text,
                DatePosted = DateTime.Now
            });

            return RedirectToAction(actionName, "Projects");
        }
    }
}