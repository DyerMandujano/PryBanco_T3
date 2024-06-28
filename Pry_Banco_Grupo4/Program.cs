using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Banco_Grupo4
{
    internal class Program
    {
        public static CuentaCola Nodoctas = new CuentaCola();

        static void Main(string[] args)
        {

            PantallaPrincipal();
        }

        public static void PantallaPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            string[] validar = { "1", "2", "3", "4" };
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ==================================================");
                Console.WriteLine("\n\t    MENU PRINCIPAL");
                Console.WriteLine("\n\t[1] Ingreso Cuenta");
                Console.WriteLine("\t[2] Eliminar Cuenta");
                Console.WriteLine("\t[3] Visualizar Cuentas");
                Console.WriteLine("\t[4] Salir");
                Console.WriteLine(" ==================================================");

                string dato = Console.ReadLine();
                int opcion = validar.Contains(dato) ? int.Parse(dato) : 0;
                switch (opcion)
                {
                    case 1: // Opción "Ingresar"
                        IngresoCuenta();
                        break;
                    case 2: // Opción "Eliminar"
                        EliminarCuenta();
                        break;
                    case 3: // Opción "Visualizar"
                        VisualizarCuenta();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(" Opción no válida");
                        Console.ReadLine();
                        opcion = 0;
                        break;

                }
            }
        }
        public static void IngresoCuenta()
        {
            string[] validarTipo = { "A", "C" };
            string[] validarMoneda = { "S", "D" };
            var culture = new CultureInfo("en-US");
            Random _random = new Random();

            Console.Clear();
            Console.WriteLine(" =============================================");
            Console.WriteLine("   INGRESO");
            Console.WriteLine(" =============================================");
            Console.Write("  Nro.Cliente                :");
            int _numeroCliente = _random.Next(105, 900);
            Console.Write(_numeroCliente);
            Console.Write("\n");
            Console.Write("Nombre Cliente               : ");
            string _nombreCliente = Console.ReadLine();
            if (_nombreCliente.Length == 0) return;
            Console.Write("  Antiguedad                 : ");
            string _antiguedad_ = Console.ReadLine();
            int _antiguedad = int.TryParse(_antiguedad_, out _) ? Int32.Parse(_antiguedad_, culture) : 0;
            if (!(_antiguedad >= 1 && _antiguedad <= 10))
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            Console.Write("  Nro.Cuenta                 : ");
            string _nrocuenta_ = Console.ReadLine();
            int _nrocuenta = int.TryParse(_nrocuenta_, out _) ? Int32.Parse(_nrocuenta_, culture) : 0;
            if (!(_nrocuenta >= 4500 && _nrocuenta <= 9230))
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            Console.Write("  Tipo Ahorro----------------- ");
            Console.Write("\n(A)horro (C)uentaCorriente   : ");
            string _tipoAhorro_ = Console.ReadLine();
            if (_tipoAhorro_.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            string _tipoAhorro = validarTipo.Contains(_tipoAhorro_) ? _tipoAhorro_ : "";
            if (_tipoAhorro.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            Console.Write("  Moneda---------------------- ");
            Console.Write("\n(S)oles (D)ólares            : ");
            string _moneda_ = Console.ReadLine();
            if (_moneda_.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            string _moneda = validarMoneda.Contains(_moneda_) ? _moneda_ : "";
            if (_moneda.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            Console.Write("  Saldo                      : ");
            string _saldo_ = Console.ReadLine();
            if (_saldo_.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            double _saldo = double.TryParse(_saldo_, out _) ? double.Parse(_saldo_, culture) : 0;
            if (!(_saldo >= 50 && _saldo <= 15000))
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            Console.Write("  Token digital              : ");
            string _token_ = Console.ReadLine();
            if (_token_.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            int _token = int.TryParse(_token_, out _) ? Int32.Parse(_token_, culture) : 0;
            if (!(_token >= 1120 && _token <= 9999))
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            CuentaBanco _cta = new CuentaBanco()
            {
                NumeroCliente = _numeroCliente,
                NombreCliente = _nombreCliente,
                Antiguedad = _antiguedad,
                NumeroCuenta = _nrocuenta,
                TipoCuenta = _tipoAhorro,
                Moneda = _moneda,
                Saldo = _saldo,
                TokenDigital = _token
            };
            Nodoctas.queue(_cta);
            Console.WriteLine("Cuenta ingresada");
            Console.ReadLine();
        }
        public static void EliminarCuenta()
        {
            Nodoctas.dequeue();
            Console.WriteLine("Cuenta eliminada");
            Console.ReadLine();
            return;
        }
        public static void VisualizarCuenta()
        {

            Console.Clear();
            Console.WriteLine("Cuentas de cliente");
            Console.WriteLine("╔════════════╦══════════════════════════╦════════════════╦══════════════════╦════════════════╦═══════════╦══════════╦══════════╗");
            Console.WriteLine("║  NRO       ║                          ║                ║                  ║      TIPO      ║           ║          ║          ║");
            Console.WriteLine("║  CLIENTE   ║    NOMBRE CLIENTE        ║  ANTIGUEDAD    ║   NRO.CUENTA     ║     CUENTA     ║   MONEDA  ║  SALDO   ║  TOKEN   ║");
            if (Nodoctas.Inicio != null)
            {
                MostrarCuenta(Nodoctas.Inicio);
            }
            Console.WriteLine("╚════════════╩══════════════════════════╩════════════════╩══════════════════╩════════════════╩═══════════╩══════════╩══════════╝");
            Console.ReadLine();

        }
        public static void MostrarCuenta(CuentaBanco unaCta)
        {
            Console.WriteLine("╠════════════╬══════════════════════════╬════════════════╬══════════════════╬════════════════╬═══════════╬══════════╬══════════╣");
            Console.WriteLine("║" + unaCta.NumeroCliente.ToString().PadRight(12, ' ').Substring(0, 12) + "║" +
                              unaCta.NombreCliente.TrimEnd().PadRight(26).Substring(0, 26) + "║" +
                              unaCta.Antiguedad.ToString().PadRight(16, ' ').Substring(0, 16) + "║     " +
                              unaCta.NumeroCuenta.ToString().PadRight(10, ' ').Substring(0, 10) + "   ║" +
                              (unaCta.TipoCuenta == "A" ? "     AHORRO     " : "CUENTA CORRIENTE") + "║   " +
                              (unaCta.Moneda == "S" ? " SOLES  " : "DÓLARES ") + "║" +
                              unaCta.Saldo + "        ║" +
                              unaCta.TokenDigital + "      ║");
            if (unaCta.Sgte != null)
            {
                MostrarCuenta(unaCta.Sgte);
            }
        }
    }
}
