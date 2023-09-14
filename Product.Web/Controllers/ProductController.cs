using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Product.Web.Models;
using Product.Web.Service.IService;
using System.Collections.Generic;

namespace Product.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult>  ProductIndex()
        {
            List<ProductDto>? list = new();
            ResponseDto? response = await _productService.GetAllProductAsync();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

        public async Task<IActionResult> ProductCreate() { 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductCreate (ProductDto model)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? response = await _productService.CreateProductAsync(model);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(ProductIndex));
                }
                return View(model);
            }
            return View();
        }
    }
}
