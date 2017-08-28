using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccl.Negocio
{
    class Contabilidad
    {
        public int IdContabilidad { get; }
        public static Dictionary<string, decimal> Activos;
        public static Dictionary<string, decimal> Pasivos;
        public static float Capital { get; set; }
        public static float TotalPasivos { get; set; }
        public static float Deudas { get; set; }
        public float Efectivo { get; set; }
        public static float Gastos { get; set; }
        public float CuentasPorPagar { get; set; }
        public float CuentasPorCobrar { get; set; }
        public static float Utilidades { get; set; }
        public static float TotalActivos { get; set; }
        public float ExistenciaMercancia { get; set; }
        public float Beneficio;




        public void AgregarPasivo( string descripcion, decimal monto )
        {
            

            if (Pasivos == null)
            {
                Pasivos = new Dictionary<string, decimal>();
                Pasivos.Add(descripcion, monto);
            }
            else
            {
                Pasivos.Add(descripcion, monto);
            }

        }
        public void AgregarActivo(string descripcion, Decimal monto)
        {
            

            if (Activos == null)
            {
                Activos = new Dictionary<string, decimal>();
                Activos.Add(descripcion,monto);
            }
            else
            {
                Activos.Add(descripcion,monto);
            }
        }



        public static void AumentarCapital(float monto) {
            Capital = Capital + monto;
           
        }

        public float CalcularBeneficio() {
            return this.Beneficio = TotalActivos - Capital;
        }

        public void SetActivos()
        {
            TotalActivos = Efectivo + CuentasPorCobrar + ExistenciaMercancia;
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
