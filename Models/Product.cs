using System;
using System.Collections.Generic;

namespace _15_NguyenTheNam_MVC_Product_DataFirst.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public int UnitInStock { get; set; }
}
