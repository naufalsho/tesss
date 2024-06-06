using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class TblUser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public int Balance { get; set; }

    public virtual ICollection<TblTransaction> TblTransactions { get; set; } = new List<TblTransaction>();
}
