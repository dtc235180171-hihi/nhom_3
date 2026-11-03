using Microsoft.AspNetCore.Mvc;
using ProductReview.Models;

namespace ProductReview.Controllers
{
    public class ReviewController : Controller
    {
        // Dữ liệu mẫu
        private static readonly Review _review = new Review
        {
            Id = 1,
            ProductName = "Điện thoại Samsung Galaxy S24",
            Score = 9,
            Comment = "Sản phẩm tốt, pin trâu"
        };

        // Action Index trả về view Index
        public IActionResult Index()
        {
            return View();
        }

        // Action Add trả về view Add, truyền tên sản phẩm qua ViewBag
        public IActionResult Add()
        {
            ViewBag.ProductName = _review.ProductName;
            return View();
        }

        // Action Result trả về view Result, truyền điểm đánh giá qua ViewData
        public IActionResult Result()
        {
            ViewData["Score"] = _review.Score;
            return View();
        }
    }
}
