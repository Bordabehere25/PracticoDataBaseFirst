﻿using System;
using System.Collections.Generic;

namespace PracticoMVC.Models;

public partial class Personaje
{
    public int PerId { get; set; }

    public int? PerLibId { get; set; }

    public int? PerRolId { get; set; }

    public string? PerNombre { get; set; }

    public string? PerApellido { get; set; }

    public string? PerDescripcion { get; set; }

    public DateTime? PerFechaNacimiento { get; set; }

    public string? PerLugarNacimiento { get; set; }

    public string? PerStatus { get; set; }

    public virtual Libro? PerLib { get; set; }

    public virtual Role? PerRol { get; set; }
}
