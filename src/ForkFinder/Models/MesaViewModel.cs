using ForkFinder.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class MesaViewModel
{
    public int TamanhoMesa { get; set; }
    public int QuantidadeMesa { get; set; }

    public List<Mesa> Mesas { get; set; }
    public List<Agenda> Agendas { get; set; }
    public List<string> Horarios { get; set; }
    public List<Funcionamento> Funcionamento { get; set; }
    public string DiaSemana { get; set; }
    public int RestauranteId { get; set; }
    [ForeignKey("RestauranteId")]
    public Restaurante Restaurante { get; set; }
}
