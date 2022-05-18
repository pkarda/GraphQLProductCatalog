namespace ClothingCatalog.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var productModel =
                          modelBuilder
                          .HasDefaultContainer("products")
                          .Entity<Product>()
                          .HasNoDiscriminator();

            base.OnModelCreating(modelBuilder);
        }
    }
}
