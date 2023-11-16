using System;
using System.Collections.Generic;

namespace MoviESWeb.Models.DB;

public partial class Admin
{
    public int IdAdmin { get; set; }

    public string NameAdmin { get; set; } = null!;

    public string EmailAdmin { get; set; } = null!;

    public string PasswordAdmin { get; set; } = null!;
}
