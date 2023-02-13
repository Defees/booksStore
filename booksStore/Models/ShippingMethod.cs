﻿using System;
using System.Collections.Generic;

namespace booksStore.Models;

public partial class ShippingMethod
{
    public int MethodId { get; set; }

    public string? MethodName { get; set; }

    public decimal? Cost { get; set; }

    public virtual ICollection<CustOrder> CustOrders { get; } = new List<CustOrder>();
}
