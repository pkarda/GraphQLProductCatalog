using ClothingCatalog.Data;

namespace ClothingCatalog
{
    public class Query
    {
        public Person GetPerson() => new Person("Luke Skywalker");

        [UseProjection]
        [UseFiltering]
        //[UseSorting]
        public IQueryable<Product> GetProducts(ProductContext context) => context.Products.AsNoTracking();
    }

    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}