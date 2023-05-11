using System;
using System.Collections.Generic;

namespace MapsApi.Models;

public partial class CadastroCidade
{
    public int CadastroCidadeId { get; set; }

    public string? NomeCidade { get; set; }

    public virtual ICollection<Cadastro> Cadastros { get; set; } = new List<Cadastro>();
}
