using System;
using System.Collections.Generic;

namespace API_USER_CET.Models;

public partial class Introduce
{
    public int Id { get; set; }

    public string? Image { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Content { get; set; }

    public string? Creator { get; set; }

    public DateTime? Dated { get; set; }
}
