using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Banco_Grupo4
{
    class CuentaBanco
    {
        //ATRIBUTOS PRIVADOS
        private int num_cliente;
        private string nombre_cliente;
        private int antig;
        private int num_cuenta;
        private string tipo_cuenta;
        private string moneda;
        private double saldo;
        private int token_dg;
        private static Random r = new Random();
        private CuentaBanco sgte;
        //Altura o Nivel que tiene el nodo en el Arbol
        private int altura_arb;

        //CONSTRUCTOR VACIO
        public CuentaBanco()
        {

        }

        //CONSTRUCTOR CON PARAMETROS
        public CuentaBanco(string nombre_cliente, int num_cuenta, int antig, string tipo_cuenta, string moneda, double saldo, int token_dg)
        {

            //NUMERO DE CLIENTE RANDOM
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
            Altura_Arb = 0;
        }

        //PROPIEDADES
        public CuentaBanco Sgte
        {
            get { return sgte; } //Leer el enlace siguiente
            set { sgte = value; } //Escribir enlace siguiente
        }
        public int Altura_Arb
        {
            get { return altura_arb; }
            set { altura_arb = value; }
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
