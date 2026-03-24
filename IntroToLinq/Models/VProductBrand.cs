using System;
using System.Collections.Generic;

namespace IntroToLinq.Models;

public partial class VProductBrand
{
    public string ProductName { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public decimal ListPrice { get; set; }
}
