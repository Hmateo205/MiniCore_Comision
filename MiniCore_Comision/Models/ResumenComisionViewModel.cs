namespace MiniCore_Comision.Models
{
    public class ResumenComisionViewModel
    {
        public string NombreVendedor { get; set; }
        public decimal TotalVentas { get; set; }

        public decimal PorcentajeComision { get; set; } = 0.1m; // 10%

        public decimal TotalComision => TotalVentas * PorcentajeComision;
    }
}
    