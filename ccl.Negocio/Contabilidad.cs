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
        public float Capital { get; set; }
        public float Pasivos { get; set; }
        public float Deudas { get; set; }
        public float Gastos { get; set; }
        public float CuentasPorPagar { get; set; }
        public float CuentasPorCobrar { get; set; }
        public float BalanceAnterior { get; set; }
        public float BalanceActual { get; set; }
        public float Ingresos { get; set; }
        public float Utilidades { get; set; }
        public float Costos { get; set; }
        public float Activos { get; set; }
        


        public void AumentarCapital(float monto) {
            this.Capital = this.Capital + monto;
           
        }

        public Contabilidad() {
        }
        
        public void HacerBalance() {
            
            this.Utilidades = this.Ingresos - (this.Gastos + this.Costos + this.Deudas);
            this.BalanceActual = this.BalanceActual + Utilidades;

            if (this.Utilidades > 0)
                AumentarCapital(Utilidades);
            else
                DisminuirCapital(Utilidades);

        }
        public void SaldarDeuda() {
            Deudas = 0.0f;
        }
        public void DisminuirCapital(float monto) {
            if (monto > this.Capital || monto < this.Capital)
                return;
            this.Capital = this.Capital - monto;

        }
    }

}
