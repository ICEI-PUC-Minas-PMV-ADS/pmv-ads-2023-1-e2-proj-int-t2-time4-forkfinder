using System.Collections.Generic;

namespace ForkFinder.ViewModels
{
    public class CombinedViewModel
    {
        public List<MesaComReservas> MesasComReservas { get; set; }
        public List<ReservaViewModel> Reservas { get; set; }
    }
}
