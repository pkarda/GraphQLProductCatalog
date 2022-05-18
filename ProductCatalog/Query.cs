using ClothingCatalog.Data;

namespace ClothingCatalog
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        //[UseSorting]
        public IQueryable<Product> GetProducts(ProductContext context) => context.Products.AsNoTracking();
    }
}