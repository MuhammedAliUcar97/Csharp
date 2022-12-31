using System;
using System.Collections.Generic;

namespace todolist.Models;

public partial class Todo
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public ulong Iscomplated { get; set; }
}
