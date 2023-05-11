using System;
using System.Collections.Generic;

namespace MapsApi.Models;

public partial class CadastroPai
{
    public int CadastroPaisId { get; set; }

    public string? NomePais { get; set; }

    public virtual ICollection<Cadastro> Cadastros { get; set; } = new List<Cadastro>();
}
