using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using KitapDuragi.business.Abstract;
using KitapDuragi.webui.EmailServices;
using KitapDuragi.webui.Extensions;
using KitapDuragi.webui.Identity;
using KitapDuragi.webui.Models;


namespace KitapDuragi.webui.Controllers
{
    public class ProductController : Controller
    {
        private readonly CommentService _commentService;

        public ProductController(CommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public IActionResult AddComment(int productId, string userName, string text)
        {
            var comment = new Comment
            {
                ProductId = productId,
                UserName = userName,
                Text = text
            };
            _commentService.AddComment(comment);

            return RedirectToAction("Details", new { id = productId });
        }

        public IActionResult Details(int id)
        {
            var comments = _commentService.GetCommentsByProductId(id);
            ViewBag.Comments = comments;
            // Diğer ürün detaylarını model üzerinden geçirebilirsiniz.
            return View();
        }
    }
}