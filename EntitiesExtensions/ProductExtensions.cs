using Microsoft.EntityFrameworkCore;
using TasteFoodIt.Context;
using TasteFoodIt.Dto.ProductDto;
using System.Collections.Generic;
using System.Linq;

namespace TasteFoodIt.EntitiesExtensions
{
    public static class ProductExtensions
    {
        // Tüm ürünleri getir, kategoriye göre filtre yok
        public static List<ProductListDto> GetAllProducts(this TasteContext context)
        {
            return context.Products
                .Include(p => p.Category) // Category ilişkisini yükle
                .Select(p => new ProductListDto
                {
                    ProductName = p.ProductName,
                    Descripiton = p.Description,   // yazım düzeltildi
                    ImageUrl = p.ImageUrl,
                    CategoryName = p.Category.CategoryName,
                    Price = p.Price,
                })
                .ToList();
        }
    }
}