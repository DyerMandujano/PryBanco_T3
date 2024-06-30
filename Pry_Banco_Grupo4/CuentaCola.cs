using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Banco_Grupo4
{
    internal class CuentaCola
    {
        //Cola CuentasClientes

        CuentaBanco _inicio;

        public CuentaBanco Inicio
        {
            get { return _inicio; }
        }


        //METODO PARA ENCOLAR
        public void queue(CuentaBanco unaCuentaCliente)
        {
            if (_inicio == null)
            {
                _inicio = unaCuentaCliente;
            }
            else
            {
                CuentaBanco aux = BuscarUltimo(_inicio);
                aux.Sgte = unaCuentaCliente;
            }
        }

        private CuentaBanco BuscarUltimo(CuentaBanco unaCuentaCliente)
        {
            if (unaCuentaCliente.Sgte == null)
            {
                return unaCuentaCliente;
            }
            else
            {
                return BuscarUltimo(unaCuentaCliente.Sgte);
            }
        }

        //METODO PARA DESENCOLAR
        public void dequeue()
        {
            _inicio = _inicio.Sgte;
        }
        public void MostrarClientesAntiguedad1_5años()
        {
            Console.WriteLine("╔════════════╦══════════════════════════╦════════════════╦══════════════════╦═══════════╦═════════╦═════════╦═════════╗");
            Console.WriteLine("║  NRO       ║    NOMBRE CLIENTE        ║  ANTIGUEDAD    ║   NRO.CUENTA     ║   TIPO    ║  MONEDA ║  SALDO  ║  TOKEN  ║");
            Console.WriteLine("║  CLIENTE   ║                          ║  AÑOS          ║                  ║  CUENTA   ║         ║         ║         ║");
            Console.WriteLine("╠════════════╬══════════════════════════╬════════════════╬══════════════════╬═══════════╬═════════╬═════════╬═════════╣");

            CuentaBanco cliente_actual = _inicio;
            while (cliente_actual != null)
            {
                if (cliente_actual.Antiguedad >= 1 && cliente_actual.Antiguedad <= 5)
                {
                    Console.WriteLine("║ {0,-11}║ {1,-25}║ {2,-15}║ {3,-17}║ {4,-10}║ {5,-8}║ {6,-8}║ {7,-8}║", cliente_actual.NumeroCliente, cliente_actual.NombreCliente, cliente_actual.Antiguedad, cliente_actual.NumeroCuenta, cliente_actual.TipoCuenta, cliente_actual.Moneda, cliente_actual.Saldo, cliente_actual.TokenDigital);
                    //Console.WriteLine($"║  {cliente_actual.NumeroCliente,-10}║  {cliente_actual.NombreCliente,-24}║  {cliente_actual.Antiguedad,-16}║  {cliente_actual.NumeroCuenta,-18}║  {cliente_actual.TipoCuenta,-13}║  {cliente_actual.Moneda,-9}║  {cliente_actual.Saldo,-9}║  {cliente_actual.TokenDigital,-9}║");
                }
                cliente_actual = cliente_actual.Sgte;
            }

            Console.WriteLine("╚════════════╩══════════════════════════╩════════════════╩══════════════════╩═══════════╩═════════╩═════════╩═════════╝");
        }
        public void MostrarClientesAntiguedad6_10años()
        {
            Console.WriteLine("╔════════════╦══════════════════════════╦════════════════╦══════════════════╦═══════════╦═════════╦═════════╦═════════╗");
            Console.WriteLine("║  NRO       ║    NOMBRE CLIENTE        ║  ANTIGUEDAD    ║   NRO.CUENTA     ║   TIPO    ║  MONEDA ║  SALDO  ║  TOKEN  ║");
            Console.WriteLine("║  CLIENTE   ║                          ║  AÑOS          ║                  ║  CUENTA   ║         ║         ║         ║");
            Console.WriteLine("╠════════════╩══════════════════════════╩════════════════╩══════════════════╩═══════════╩═════════╩═════════╩═════════╣");

            CuentaBanco cliente_actual = _inicio;
            string tp, tm;
            while (cliente_actual != null)
            {
                if (cliente_actual.Antiguedad >= 6 && cliente_actual.Antiguedad <= 10)
                {
                    
                    if (cliente_actual.TipoCuenta.Equals("A"))
                    {
                        tp = "AHORRO";
                        Console.WriteLine("VALOR TP: " + tp);
                    }else
                        tp = "CORRIENTE";

                    Console.WriteLine("║ {0,-11}║ {1,-25}║ {2,-15}║ {3,-17}║ {4,-10}║ {5,-8}║ {6,-8}║ {7,-8}║", cliente_actual.NumeroCliente, cliente_actual.NombreCliente, cliente_actual.Antiguedad, cliente_actual.NumeroCuenta, tp, cliente_actual.Moneda, cliente_actual.Saldo, cliente_actual.TokenDigital);
                    //Console.WriteLine($"║  {cliente_actual.NumeroCliente,-10}║  {cliente_actual.NombreCliente,-24}║  {cliente_actual.Antiguedad,-16}║  {cliente_actual.NumeroCuenta,-18}║  {cliente_actual.TipoCuenta,-13}║  {cliente_actual.Moneda,-9}║  {cliente_actual.Saldo,-9}║  {cliente_actual.TokenDigital,-9}║");
                }
                cliente_actual = cliente_actual.Sgte;
            }

            Console.WriteLine("╚════════════╩══════════════════════════╩════════════════╩══════════════════╩═══════════╩═════════╩═════════╩═════════╝");
        }

        public void MostrarClientesPorTipoDeCuenta(string tipoCuenta)
        {
            Console.WriteLine("╔════════════╦══════════════════════════╦════════════════╦══════════════════╦═══════════╦═════════╦═════════╦═════════╗");
            Console.WriteLine("║  NRO       ║    NOMBRE CLIENTE        ║  ANTIGUEDAD    ║   NRO.CUENTA     ║   TIPO    ║  MONEDA ║  SALDO  ║  TOKEN  ║");
            Console.WriteLine("║  CLIENTE   ║                          ║                ║                  ║  CUENTA   ║         ║         ║         ║");
            Console.WriteLine("╠════════════╬══════════════════════════╬════════════════╬══════════════════╬═══════════╬═════════╬═════════╬═════════╣");

            CuentaBanco cliente_actual = _inicio;
            while (cliente_actual != null)
            {
                if (cliente_actual.TipoCuenta == tipoCuenta)
                {
                    Console.WriteLine("║ {0,-11}║ {1,-25}║ {2,-15}║ {3,-17}║ {4,-10}║ {5,-8}║ {6,-8}║ {7,-8}║", cliente_actual.NumeroCliente, cliente_actual.NombreCliente, cliente_actual.Antiguedad, cliente_actual.NumeroCuenta, cliente_actual.TipoCuenta, cliente_actual.Moneda, cliente_actual.Saldo, cliente_actual.TokenDigital);
                    //Console.WriteLine($"║  {cliente_actual.NumeroCliente,-10}║  {cliente_actual.NombreCliente,-24}║  {cliente_actual.Antiguedad,-16}║  {cliente_actual.NumeroCuenta,-18}║  {cliente_actual.TipoCuenta,-13}║  {cliente_actual.Moneda,-9}║  {cliente_actual.Saldo,-9}║  {cliente_actual.TokenDigital,-9}║");
                }
                cliente_actual = cliente_actual.Sgte;
            }

            Console.WriteLine("╚════════════╩══════════════════════════╩════════════════╩══════════════════╩═══════════╩═════════╩═════════╩═════════╝");
        }
        public void MostrarClientesPorTipoMoneda()
        {
            double PorcentajeSoles;
            double PorcentajeDolares;
            int TotalClientes = 0;
            int TotalSoles = 0;
            int TotalDolares = 0;

            Console.WriteLine("╔════════════╦══════════════════════════╦════════════════╦══════════════════╦═══════════╦═════════╦═════════╦═════════╗");
            Console.WriteLine("║  NRO       ║    NOMBRE CLIENTE        ║  ANTIGUEDAD    ║   NRO.CUENTA     ║   TIPO    ║  MONEDA ║  SALDO  ║  TOKEN  ║");
            Console.WriteLine("║  CLIENTE   ║                          ║                ║                  ║  CUENTA   ║         ║         ║         ║");
            Console.WriteLine("╠════════════╩══════════════════════════╩════════════════╩══════════════════╩═══════════╩═════════╩═════════╩═════════╣");

            CuentaBanco cliente_actual = _inicio;

            Console.WriteLine("║     CLIENTES EN SOLES                                                                                               ║");
            Console.WriteLine("╠════════════╦══════════════════════════╦════════════════╦══════════════════╦═══════════╦═════════╦═════════╦═════════╣");
            while (cliente_actual != null)
            {
                if (cliente_actual.Moneda == "SOLES")
                {
                    Console.WriteLine("║ {0,-11}║ {1,-25}║ {2,-15}║ {3,-17}║ {4,-10}║ {5,-8}║ {6,-8}║ {7,-8}║", cliente_actual.NumeroCliente, cliente_actual.NombreCliente, cliente_actual.Antiguedad, cliente_actual.NumeroCuenta, cliente_actual.TipoCuenta, cliente_actual.Moneda, cliente_actual.Saldo, cliente_actual.TokenDigital);
                    //Console.WriteLine($"║  {cliente_actual.NumeroCliente,-10}║  {cliente_actual.NombreCliente,-24}║  {cliente_actual.Antiguedad,-16}║  {cliente_actual.NumeroCuenta,-18}║  {cliente_actual.TipoCuenta,-13}║  {cliente_actual.Moneda,-9}║  {cliente_actual.Saldo,-9}║  {cliente_actual.TokenDigital,-9}║");
                    TotalSoles++;
                }
                TotalClientes++;
                cliente_actual = cliente_actual.Sgte;
            }
            Console.WriteLine("╠════════════╩══════════════════════════╩════════════════╩══════════════════╩═══════════╩═════════╩═════════╩═════════╣");
            Console.WriteLine("║     Clientes en Dólares                                                                                             ║");
            Console.WriteLine("╠════════════╦══════════════════════════╦════════════════╦══════════════════╦═══════════╦═════════╦═════════╦═════════╣");
            cliente_actual = _inicio;

            while (cliente_actual != null)
            {
                if (cliente_actual.Moneda == "DOLARES")
                {
                    Console.WriteLine("║ {0,-11}║ {1,-25}║ {2,-15}║ {3,-17}║ {4,-10}║ {5,-8}║ {6,-8}║ {7,-8}║", cliente_actual.NumeroCliente, cliente_actual.NombreCliente, cliente_actual.Antiguedad, cliente_actual.NumeroCuenta, cliente_actual.TipoCuenta, cliente_actual.Moneda, cliente_actual.Saldo, cliente_actual.TokenDigital);
                    //Console.WriteLine($"║  {cliente_actual.NumeroCliente,-10}║  {cliente_actual.NombreCliente,-24}║  {cliente_actual.Antiguedad,-16}║  {cliente_actual.NumeroCuenta,-18}║  {cliente_actual.TipoCuenta,-13}║  {cliente_actual.Moneda,-9}║  {cliente_actual.Saldo,-9}║  {cliente_actual.TokenDigital,-9}║");
                    TotalDolares++;
                }
                cliente_actual = cliente_actual.Sgte;
            }
            PorcentajeSoles = (double)TotalSoles / TotalClientes * 100;
            PorcentajeDolares = (double)TotalDolares / TotalClientes * 100;

            Console.WriteLine("╠════════════╩══════════════════════════╩════════════════╩══════════════════╩═══════════╩═════════╩═════════╩═════════╣");
            Console.WriteLine($"║     Porcentaje de clientes en Soles: {PorcentajeSoles:f2}%                                                                         ║");
            Console.WriteLine($"║     Porcentaje de clientes en Dólares: {PorcentajeDolares:f2}%                                                                       ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}
