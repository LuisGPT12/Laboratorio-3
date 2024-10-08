using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class CuentaManagement
    {
        private string nombreClient = "";
        private double saldo = 0.00;
        private List<double> movimientos = new List<double>();

        public CuentaManagement() { }

        public CuentaManagement(String nombreClient, double montoInicial)
        {
            this.nombreClient = nombreClient.Trim();
            this.saldo = montoInicial;
            this.movimientos.Add(montoInicial);
        }

        public void deposito(double monto)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("un depósito no puede ser menor a 0");
            }
            this.movimientos.Add(monto);
            this.saldo += monto;
        }

        public bool retiro(double monto)
        {
            if (saldo >= monto)
            {
                this.movimientos.Add(monto * -1);
                this.saldo -= monto;
                return true;
            }
            return false;
        }

        // Getters y Setters
        public double getSaldo() 
        { 
            return saldo; 
        }

        public string getNombre()
        {
            return nombreClient;
        }

        public List<double> getMovimientos() 
        {
            return movimientos; 
        }

        public List<double> getDepositos()
        {
            return movimientos.FindAll(x => x > 0);
        }

        public List<double> getRetiros()
        {
            return movimientos.FindAll(x =>x < 0);
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public void setNombre(string nombre)
        {
            nombreClient = nombre.Trim();
        }

        public void setMovimientos(List<double> movimientos)
        {
            this.movimientos = movimientos;
        }
    }
}
