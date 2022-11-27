using System;
using System.Collections.Generic;

namespace ShopBL.Models;

public partial class OrderDetail
{
    public string ProductId { get; set; } = null!;

    public int OrderId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Price { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
