using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models;

public partial class Team
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
