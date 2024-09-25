using System;
using System.Collections.Generic;

namespace ProductsManufacturer.Models;

public partial class Sale
{
    public int IdSale { get; set; }

    public DateOnly? Date { get; set; }
}
