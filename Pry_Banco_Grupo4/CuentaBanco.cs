using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Banco_Grupo4
{
    class CuentaBanco
    {
        private int num_cliente;
        private string nombre_cliente;
        private int antig;
        private int num_cuenta;
        private string tipo_cuenta;
        private string moneda;
        private double saldo;
        private int token_dg;
        private CuentaBanco sgte;
        public CuentaBanco()
        {

        }

        public CuentaBanco(string nombre_cliente, int num_cuenta, int antig, string tipo_cuenta, string moneda, double saldo, int token_dg)
        {
            Random r = new Random();
            //CEUNTA DE BANCOS
            NumeroCliente = r.Next(105, 900);
            NombreCliente = nombre_cliente;
            Antiguedad = antig;
            NumeroCuenta = num_cuenta;
            TipoCuenta = tipo_cuenta;
            Moneda = moneda;
            Saldo = saldo;
            TokenDigital = token_dg;
            //Inicializar el enlace en null
            Sgte = null;
        }
        public CuentaBanco Sgte
        {
            get { return sgte; } //Leer el enlace siguiente
            set { sgte = value; } //Escribir enlace siguiente
        }

        public int NumeroCliente
        {
            get { return num_cliente; }
            set { num_cliente = value; }
        }

        public string NombreCliente
        {
            get { return nombre_cliente; }
            set { nombre_cliente = value; }
        }

        public int Antiguedad
        {
            get { return antig; }
            set { antig = value; }
        }

        public int NumeroCuenta
        {
            get { return num_cuenta; }
            set { num_cuenta = value; }
        }

        public string TipoCuenta
        {
            get { return tipo_cuenta; }
            set { tipo_cuenta = value; }
        }

        public string Moneda
        {
            get { return moneda; }
            set { moneda = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public int TokenDigital
        {
            get { return token_dg; }
            set { token_dg = value; }
        }
    }
}
