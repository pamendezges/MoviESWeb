using System;
using System.Collections.Generic;

namespace MoviESWeb.Models.DB;

public partial class Documentary
{
    public int IdDocumentary { get; set; }

    public string Title { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string TvProducer { get; set; } = null!;

    public bool Voiceover { get; set; }

    public string? Img { get; set; }
}
