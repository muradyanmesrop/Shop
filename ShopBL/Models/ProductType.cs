using System;
using System.Collections.Generic;

namespace ShopBL.Models;

public partial class ProductType
{
    public int ProductTypeId { get; set; }

    public string? ProductTypeName { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
