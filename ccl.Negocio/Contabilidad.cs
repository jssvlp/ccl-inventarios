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
        public List<Activo> Activos;
        public List<Pasivo> Pasivos;


        public void AgregarPasivo(string descrpicion)
        { }
        public void AgregarActivo(string descripcion, Decimal monto)
        {
            Activo activo = new Activo();
            activo.DescripcionActivo = descripcion;
            activo.MontoActivo       = monto;

            if (Activos == null)
            {
                Activos = new List<Activo>();
                Activos.Add(activo);
            }
            else { Activos.Add(activo); }
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
