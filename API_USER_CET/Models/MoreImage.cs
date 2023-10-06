using System;
using System.Collections.Generic;

namespace API_USER_CET.Models;

public partial class MoreImage
{
    public int Id { get; set; }

    public int? NewId { get; set; }

    public string? NameImg { get; set; }

    public DateTime? Dated { get; set; }

    public string? Image { get; set; }

    public virtual NewsArticle? New { get; set; }
}
