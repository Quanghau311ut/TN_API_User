using System;
using System.Collections.Generic;

namespace API_USER_CET.Models;

public partial class Hotline
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Tel { get; set; }

    public string? Content { get; set; }

    public DateTime? Dated { get; set; }
}
