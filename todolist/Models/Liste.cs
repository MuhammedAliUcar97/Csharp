using System;
using System.Collections.Generic;

namespace todolist.Models;

public partial class Liste
{
    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public DateOnly Tarih { get; set; }
}
