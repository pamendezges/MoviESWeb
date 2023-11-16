using System;
using System.Collections.Generic;

namespace MoviESWeb.Models.DB;

public partial class User
{
    public int IdUser { get; set; }

    public string NameUser { get; set; } = null!;

    public string EmailUser { get; set; } = null!;

    public string PasswordUser { get; set; } = null!;
}
