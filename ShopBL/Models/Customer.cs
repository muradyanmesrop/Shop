using System;
using System.Collections.Generic;

namespace ShopBL.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Phone { get; set; }

    public string? Adress1 { get; set; }

    public string? Adress2 { get; set; }

    public decimal? CreditLimit { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
