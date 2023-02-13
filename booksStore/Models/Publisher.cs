using System;
using System.Collections.Generic;

namespace booksStore.Models;

public partial class Publisher
{
    public int PublisherId { get; set; }

    public string? PublisherName { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
