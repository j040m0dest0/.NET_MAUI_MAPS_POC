using System;
using System.Collections.Generic;

namespace MapsApi.Models;

public partial class Chamado
{
    public int ChamadosId { get; set; }

    public int? CadastroId { get; set; }

    public int? AlertaId { get; set; }

    public string? Descricao { get; set; }

    public DateTime? DataHora { get; set; }

    public int? Lat { get; set; }

    public int? Long { get; set; }

    public bool? Cancelado { get; set; }

    public virtual Alertum? Alerta { get; set; }

    public virtual Cadastro? Cadastro { get; set; }
}
