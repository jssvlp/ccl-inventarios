using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccl.Negocio
{
    class Contabilidad
    {
        public int Id { get; set; }
        public static float Capital { get; set; }
        public static float Pasivos { get; set; }
        public static float Deudas { get; set; }
        public  float Efectivo { get; set; }
        public static float Gastos { get; set; }
        public float CuentasPorPagar { get; set; }
        public float CuentasPorCobrar { get; set; }
        public static float BalanceAnterior { get; set; }
        public static float BalanceActual { get; set; }
        public static float Ingresos { get; set; }
        public static float Utilidades { get; set; }
        public static float Costos { get; set; }
        public static float Activos { get; set; }
        public float ExistenciaMercancia { get; set; }
        public float Beneficio;
        


        public static void AumentarCapital(float monto) {
            Capital = Capital + monto;
           
        }

        public float CalcularBeneficio() {
            return this.Beneficio = Activos - Capital;
        }

        public void SetActivos()
        {
            Activos = Efectivo + CuentasPorCobrar + ExistenciaMercancia;
        }

        public Contabilidad() {
            CuentasPorCobrar = 0;
            Efectivo = 0;
            ExistenciaMercancia = 0;
        }
        
        
        public void SaldarDeuda() {
            Deudas = 0.0f;
        }
        public void DisminuirCapital(float monto) {
            if (monto > Capital || monto < Capital)
                return;
            Capital = Capital - monto;

        }
    }

}
