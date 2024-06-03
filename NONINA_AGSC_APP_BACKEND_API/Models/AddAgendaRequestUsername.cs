using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NONINA_AGSC_APP_BACKEND.Models;

public partial class AddAgendaRequestUsername
{
    public long Id { get; set; }
    public string Username { get; set; } = null!;

    public long EventoId { get; set; }

}
