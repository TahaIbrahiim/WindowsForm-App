using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class Player
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Position { get; set; }

    public int? TeamId { get; set; }

    public virtual Team? Team { get; set; }
}
