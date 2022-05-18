using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingCatalog.Data
{
    public class Product
    {
        public string? id { get; set; }
        public string? productId { get; set; }
        public string? category { get; set; }
        public string? manufacturer { get; set; }
        public string? description { get; set; }
        public string? price { get; set; }

        public ShippingInformation? shipping { get; set; }

        public ProductLocalizations? productLocalizations { get; set; }
    }

    public class ProductLocalizations
    {
        public IList<ProductLocalization>? localizations { get; set; }
    }

    public class ProductLocalization
    {
        public string? name { get; set; }
        public string? lang { get; set; }
    }

    public class ShippingInformation
    {
        public int? weight { get; set; }
        public ShippingDimensions dimensions { get; set; }
    }

    public class ShippingDimensions
    {
        public int? width { get; set; }
        public int? height { get; set; }
        public int? depth { get; set; }

    }
}
