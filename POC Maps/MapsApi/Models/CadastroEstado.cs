using System;
using System.Collections.Generic;

namespace MapsApi.Models;

public partial class CadastroEstado
{
    public int CadastroEstadoId { get; set; }

    public string? NomeEstado { get; set; }

    public virtual ICollection<Cadastro> Cadastros { get; set; } = new List<Cadastro>();
}
