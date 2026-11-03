using Microsoft.AspNetCore.Mvc;

namespace ProductReview.Controllers
{
    public class ReviewController : Controller
    {
        // Action Index trả về view Index
        public IActionResult Index()
        {
            return View();
        }

        // Action Add trả về view Add, truyền tên sản phẩm qua ViewBag
        public IActionResult Add()
        {
            ViewBag.ProductName = "Điện thoại Samsung Galaxy S24";
            return View();
        }

        // Action Result trả về view Result, truyền điểm đánh giá qua ViewData
        public IActionResult Result()
        {
            ViewData["Score"] = 9;
            return View();
        }
    }
}
