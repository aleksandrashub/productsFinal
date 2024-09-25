using System;
using System.Collections.Generic;

namespace ProductsManufacturer.Models;

public partial class SaleTovar
{
    public int? IdTovar { get; set; }

    public int? Amount { get; set; }

    public int? IdSale { get; set; }

    public virtual Sale? IdSaleNavigation { get; set; }
}
