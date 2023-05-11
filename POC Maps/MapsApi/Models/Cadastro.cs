using System;
using System.Collections.Generic;

namespace MapsApi.Models;

public partial class Cadastro
{
    public int CadastroId { get; set; }

    public int? CadastroPaisId { get; set; }

    public int? CadastroCidadeId { get; set; }

    public int? CadastroEstadoId { get; set; }

    public string? Nome { get; set; }

    public long? NumOab { get; set; }

    public bool? Ativo { get; set; }

    public bool? Administrador { get; set; }

    public string? Rua { get; set; }

    public string? Bairro { get; set; }

    public string? NumCasa { get; set; }

    public string? Complemento { get; set; }

    public string? Email { get; set; }

    public string? Senha { get; set; }

    public string? SenhaAdministrador { get; set; }

    public virtual CadastroCidade? CadastroCidade { get; set; }

    public virtual CadastroEstado? CadastroEstado { get; set; }

    public virtual CadastroPai? CadastroPais { get; set; }

    public virtual ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();

    public virtual ICollection<Historico> Historicos { get; set; } = new List<Historico>();
}
