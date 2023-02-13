using System;
using System.Collections.Generic;

namespace booksStore.Models;

public partial class OrderStatus
{
    public int StatusId { get; set; }

    public string? StatusValue { get; set; }

    public virtual ICollection<OrderHistory> OrderHistories { get; } = new List<OrderHistory>();
}
