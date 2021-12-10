using _0306191183_Buoi2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191183_Buoi2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                Name = "Cá saba đông lạnh túi 400g",
                Description = "Cá saba với đặc tính ít xương khi chế biến thịt sẽ có vị ngọt thơm và ăn rất ngon",
              
                Price = 28000,
                ImagePath = "1.jpg"

            }) ;
            products.Add(new Product
            {
                Name = "Cá hồi đông lạnh túi 300g",
                Description = "Với thịt cá ngọt, béo ngậy, tươi rói, cá hồi thường được các chị em chọn làm nguyên liệu chính cho các bữa ăn. ",
                Price = 120000,
                ImagePath = "2.jpg"

            });
            products.Add(new Product
            {
                Name = "Cá trích nhập khẩu đông lạnh túi 500g",
                Description = "loài cá tuyệt hảo đối với sức khỏe của con người bởi chứa lượng lớn chất dinh dưỡng quan trọng tốt cho sức khỏe. ",
                Price = 34500,
                ImagePath = "3.jpg"

            });
            products.Add(new Product
            {
                Name = "Cá nục đông lạnh túi 500g",
                Description = "Là loại cá mang đến nhiều dưỡng chất có lợi và công dụng tuyệt vời cho sức khoẻ."
               ,
                Price = 40000,
                ImagePath = "4.jpg"

            });
            return View(products);

        }
    }
}
