using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class TblTransaction
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public int TotalCost { get; set; }

    public DateTime TransactionDate { get; set; }

    public virtual TblProduct Product { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
