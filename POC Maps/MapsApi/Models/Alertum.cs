using System;
using System.Collections.Generic;

namespace MapsApi.Models;

public partial class Alertum
{
    public int AlertaId { get; set; }

    public bool? Tipo { get; set; }

    public string? Descricao { get; set; }

    public bool? Cancelar { get; set; }

    public virtual ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();

    public virtual ICollection<Historico> Historicos { get; set; } = new List<Historico>();
}
