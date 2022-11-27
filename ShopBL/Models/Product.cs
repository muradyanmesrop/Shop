using System;
using System.Collections.Generic;

namespace ShopBL.Models;

public partial class Product
{
    public string ProductId { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public int? ProductTypeId { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual ProductType? ProductType { get; set; }
}
