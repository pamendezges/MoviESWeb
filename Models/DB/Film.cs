using System;
using System.Collections.Generic;

namespace MoviESWeb.Models.DB;

public partial class Film
{
    public int IdFilm { get; set; }

    public string Title { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Director { get; set; } = null!;

    public string Producer { get; set; } = null!;

    public string MainActor { get; set; } = null!;

    public string? Img { get; set; }
}
