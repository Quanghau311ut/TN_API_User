using System;
using System.Collections.Generic;

namespace API_USER_CET.Models;

public partial class Acount
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public string? Email { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}
