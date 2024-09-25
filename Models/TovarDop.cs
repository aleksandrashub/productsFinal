using System;
using System.Collections.Generic;

namespace ProductsManufacturer.Models;

public partial class TovarDop
{
    public int IdMainDop { get; set; }

    public int? IdDopTov { get; set; }

    public int? IdMainTov { get; set; }

    public virtual Tovar? IdDopTovNavigation { get; set; }

    public virtual Tovar? IdMainTovNavigation { get; set; }

    public virtual ICollection<Tovar> Tovars { get; set; } = new List<Tovar>();
}
