using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class TblProduct
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Price { get; set; } = null!;

    public int Quantity { get; set; }

    // public virtual ICollection<TblTransaction> TblTransactions { get; set; } = new List<TblTransaction>();
}
