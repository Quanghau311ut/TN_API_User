using System;
using System.Collections.Generic;

namespace API_USER_CET.Models;

public partial class Menu
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime? Dated { get; set; }

    public string? Creator { get; set; }
}
