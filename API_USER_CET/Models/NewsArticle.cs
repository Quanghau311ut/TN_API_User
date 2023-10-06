using System;
using System.Collections.Generic;

namespace API_USER_CET.Models;

public partial class NewsArticle
{
    public int Id { get; set; }

    public int? CategoriesId { get; set; }

    public string? Image { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Content { get; set; }

    public DateTime? Dated { get; set; }

    public string? Created { get; set; }

    public virtual Category? Categories { get; set; }

    public virtual ICollection<MoreImage> MoreImages { get; set; } = new List<MoreImage>();
}
