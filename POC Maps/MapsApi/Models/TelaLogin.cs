using System;
using System.Collections.Generic;

namespace MapsApi.Models;

public partial class TelaLogin
{
    public int? CadastroId { get; set; }

    public virtual Cadastro? Cadastro { get; set; }
}
