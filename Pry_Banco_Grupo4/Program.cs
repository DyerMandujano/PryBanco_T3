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
        public static int opc;
        public static ArbolCuentaBanco arbolCuentaCli = new ArbolCuentaBanco();

        static void Main(string[] args)
        {
            Console.SetWindowSize(130, 50);
            PantallaPrincipal();

        }

        public static void PantallaPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            /*
            CuentaBanco c1 = new CuentaBanco("Jose", 4800, 3, "A", "S", 3400, 8000);
            CuentaBanco c2 = new CuentaBanco("Federico", 4950, 8, "C", "D", 2090, 1300);
            CuentaBanco c3 = new CuentaBanco("Ronaldo", 5800, 4, "A", "S", 3000, 1400);
            CuentaBanco c4 = new CuentaBanco("Piero", 5000, 10, "C", "D", 5400, 1500);
            CuentaBanco c5= new CuentaBanco("Juana", 5189, 7, "A", "S", 700, 1600);

            Nodoctas.queue(c1);
            Nodoctas.queue(c2);
            Nodoctas.queue(c3);
            Nodoctas.queue(c4);
            Nodoctas.queue(c5);
            arbolCuentaCli.insertaNodo(c1);
            arbolCuentaCli.insertaNodo(c2);
            arbolCuentaCli.insertaNodo(c3);
            arbolCuentaCli.insertaNodo(c4);
            arbolCuentaCli.insertaNodo(c5);*/


            CuentaBanco c1 = new CuentaBanco("ANA GUERRA", 8648, 8, "A", "S", 9640, 1876);
            CuentaBanco c2 = new CuentaBanco("JULIO GUEVARA", 4939, 9, "C", "S", 746, 4533);
            CuentaBanco c3 = new CuentaBanco("DORA MILLAN", 8463, 5, "C", "D", 10228, 7532);
            CuentaBanco c4 = new CuentaBanco("CARLOS DIAZ", 5606, 4, "C", "D", 5400, 1500);
            CuentaBanco c5 = new CuentaBanco("SARA MONTERO", 5189, 7, "A", "S", 700, 1600);
            CuentaBanco c6 = new CuentaBanco("JULIO GUEVANA", 5730, 8, "C", "S", 4549, 9554);
            CuentaBanco c7 = new CuentaBanco("ANGEL VICTORINO", 8542, 2, "A", "D", 8122, 1921);
            CuentaBanco c8 = new CuentaBanco("BERTHA GIL", 5476, 9, "C", "D", 8712, 9126);
            CuentaBanco c9 = new CuentaBanco("ESTEVES BARRETO", 6631, 8, "A", "S", 6888, 5255);
            CuentaBanco c10 = new CuentaBanco("CARLOS MEZA", 6148, 20, "A", "S", 14522, 5045);
            CuentaBanco c11 = new CuentaBanco("NESTOR LOO", 4958, 2, "C", "S", 8705, 9850);
            CuentaBanco c12 = new CuentaBanco("JULIO PILCO", 8740, 3, "A", "D", 460, 4176);
            CuentaBanco c13 = new CuentaBanco("ERNESTINA MILLONES", 6368, 8, "C", "D", 790, 8816);
            CuentaBanco c14 = new CuentaBanco("CARLOS MEZA", 7065, 9, "C", "S", 2791, 8025);
            CuentaBanco c15 = new CuentaBanco("CAROLINA BUENDIA", 8356, 6, "C", "S", 8136, 7598);
            CuentaBanco c16 = new CuentaBanco("FERNANDO MORENO", 5678, 3, "A", "S", 1514, 1441);
            CuentaBanco c17 = new CuentaBanco("ANA POMARES", 4691, 1, "A", "D", 10935, 6966);
            CuentaBanco c18 = new CuentaBanco("ANGEL DE LA CRUZ", 5838, 4, "A", "S", 9000, 5985);
            CuentaBanco c19 = new CuentaBanco("JOSEPH CHUQUILLANQUI", 7300, 10, "C", "S", 2399, 4948);
            CuentaBanco c20 = new CuentaBanco("DIEGO MENDOZA", 6605, 2, "C", "S", 13370, 1673);

            Nodoctas.queue(c1);
            Nodoctas.queue(c2);
            Nodoctas.queue(c3);
            Nodoctas.queue(c4);
            Nodoctas.queue(c5);
            Nodoctas.queue(c6);
            Nodoctas.queue(c7);
            Nodoctas.queue(c8);
            Nodoctas.queue(c9);
            Nodoctas.queue(c10);
            Nodoctas.queue(c11);
            Nodoctas.queue(c12);
            Nodoctas.queue(c13);
            Nodoctas.queue(c14);
            Nodoctas.queue(c15);
            Nodoctas.queue(c16);
            Nodoctas.queue(c17);
            Nodoctas.queue(c18);
            Nodoctas.queue(c19);
            Nodoctas.queue(c20);

            arbolCuentaCli.insertaNodo(c1);
            arbolCuentaCli.insertaNodo(c2);
            arbolCuentaCli.insertaNodo(c3);
            arbolCuentaCli.insertaNodo(c4);
            arbolCuentaCli.insertaNodo(c5);
            arbolCuentaCli.insertaNodo(c6);
            arbolCuentaCli.insertaNodo(c7);
            arbolCuentaCli.insertaNodo(c8);
            arbolCuentaCli.insertaNodo(c9);
            arbolCuentaCli.insertaNodo(c10);
            arbolCuentaCli.insertaNodo(c11);
            arbolCuentaCli.insertaNodo(c12);
            arbolCuentaCli.insertaNodo(c13);
            arbolCuentaCli.insertaNodo(c14);
            arbolCuentaCli.insertaNodo(c15);
            arbolCuentaCli.insertaNodo(c16);
            arbolCuentaCli.insertaNodo(c17);
            arbolCuentaCli.insertaNodo(c18);
            arbolCuentaCli.insertaNodo(c19);
            arbolCuentaCli.insertaNodo(c20);

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ╔════════════════════════════════════════════╗");
                    Console.WriteLine(" ║              Menu Cuenta Cliente           ║");
                    Console.WriteLine(" ╠════════════════════════════════════════════╣");
                    Console.WriteLine(" ║[1]Ingresar Cuenta Cliente                  ║");
                    Console.WriteLine(" ║[2]Mostrar Cuentas (COLA)                   ║");
                    Console.WriteLine(" ║[3]Mostrar Cuentas (ARBOL)                  ║");
                    Console.WriteLine(" ║[4]Eliminar Cuenta de Cliente (ARBOL)       ║");
                    Console.WriteLine(" ║[5]Buscar Cuenta por IdCliente              ║");
                    Console.WriteLine(" ║[6]Mostrar Altura del ARBOL                 ║");
                    Console.WriteLine(" ║[7]Recorrido del ARBOL en PostOrden         ║");
                    Console.WriteLine(" ║[8]Mostrar Num de Clientes por Antiguedad   ║");
                    Console.WriteLine(" ║[9]Mostrar Num de Clientes por Cuenta       ║");
                    Console.WriteLine(" ║[10]Mostrar Num de Clientes por Tipo Moneda ║");
                    Console.WriteLine(" ║[11]Salir                                   ║");
                    Console.WriteLine(" ╚════════════════════════════════════════════╝");
                    Console.Write(" ELIJA UNA OPCION: ");
                    opc = int.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            IngresoCuenta();
                            break;
                        case 2:
                            VisualizarCuenta();
                            break;
                        case 3:
                            arbolCuentaCli.muestraArbol(arbolCuentaCli.Arbol_Cuenta_Cliente, 0);
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Write("Ingrese el ID del Cliente a Eliminar: ");
                            int v_eli = int.Parse(Console.ReadLine());
                            NodoCuentaBanco ct = arbolCuentaCli.Delete(arbolCuentaCli.Arbol_Cuenta_Cliente, v_eli);
                            Console.WriteLine("Cliente con Id " + v_eli + " eliminado!");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Write("Ingrese el ID del Cliente a Buscar: ");
                            int vB = int.Parse(Console.ReadLine());
                            bool conf = arbolCuentaCli.busquedaPorNumCliente(vB);
                            if (conf)
                            {
                                Console.Write("¿Desea Actualizar Datos?: S/N ");
                                string opDatos = Console.ReadLine();
                                if (opDatos.Equals("S"))
                                {
                                    CuentaBanco ac_C = ActualizarDatosCuenta();
                                    if (ac_C != null)
                                    {
                                        arbolCuentaCli.ActualizarCuentaCliente(vB, ac_C);
                                        Console.WriteLine("\nActualización Exitosa!!");
                                    }
                                    else
                                        Console.WriteLine("Actualización Fallida");
                                }
                                else
                                    Console.WriteLine("Busqueda Concluida");
                            }
                            else
                            {
                                Console.WriteLine("");
                            }
                            Console.ReadKey();
                            break;
                        case 6:
                            int altura = arbolCuentaCli.CalcularAltura(arbolCuentaCli.Arbol_Cuenta_Cliente) - 1;
                            //arbolCuentaCli.muestraArbol(arbolCuentaCli.Arbol_Cuenta_Cliente, 0);
                            Console.WriteLine("\nLA ALTURA DEL ARBOL ES: " + altura);
                            Console.ReadKey();
                            break;
                        case 7:
                            arbolCuentaCli.postOrden(arbolCuentaCli.Arbol_Cuenta_Cliente);
                            Console.ReadKey();
                            break;
                        case 8:
                            break;
                        case 9:
                            break;
                        case 10:
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Coloque una opción valida!!.");
                    Console.ReadKey();
                }
            } while (opc != 11);


        }

        //Metodo para validar los Ingresos de Datos en Cuenta
        public static void IngresoCuenta()
        {
            string[] validarTipo = { "A", "C" };
            string[] validarMoneda = { "S", "D" };
            Random _random = new Random();
            Console.Clear();
            Console.WriteLine(" =============================================");
            Console.WriteLine("   INGRESO");
            Console.WriteLine(" =============================================");
            Console.Write("  Nro.Cliente                :");
            int _numeroCliente = _random.Next(105, 900);
            Console.Write(_numeroCliente);
            Console.Write("\n");
            Console.Write(" Nombre Cliente              : ");
            string _nombreCliente = Console.ReadLine();
            //Si esta vacio, termina la función
            if (_nombreCliente.Length == 0) return;
            Console.Write("  Antiguedad                 : ");
            string _antiguedad_ = Console.ReadLine();
            int _antiguedad = int.TryParse(_antiguedad_, out _) ? Int32.Parse(_antiguedad_) : 0;
            //Solo acepta valores de entre 1 a 10
            if (!(_antiguedad >= 1 && _antiguedad <= 10))
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            Console.Write("  Nro.Cuenta                 : ");
            string _nrocuenta_ = Console.ReadLine();
            int _nrocuenta = int.TryParse(_nrocuenta_, out _) ? Int32.Parse(_nrocuenta_) : 0;
            //Solo acepta valores de entre 4500 a 9230
            if (!(_nrocuenta >= 4500 && _nrocuenta <= 9230))
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return;
            }
            Console.Write("  Tipo Ahorro----------------- ");
            //Se elige entre dos opciones: 'A' o 'C'
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
            //Se elige entre dos opciones: 'S' o 'D'
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
            double _saldo = double.TryParse(_saldo_, out _) ? double.Parse(_saldo_) : 0;
            //Solo acepta valores de entre 50 a 15000
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
            int _token = int.TryParse(_token_, out _) ? Int32.Parse(_token_) : 0;
            //Solo acepta valores de entre 1120 a 9999
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
            arbolCuentaCli.insertaNodo(_cta);
            Console.WriteLine("Cuenta ingresada");
            Console.ReadLine();
        }

        public static CuentaBanco ActualizarDatosCuenta()
        {
            string[] validarTipo = { "A", "C" };
            string[] validarMoneda = { "S", "D" };
            Console.Clear();
            Console.WriteLine(" =============================================");
            Console.WriteLine("   INGRESO");
            Console.WriteLine(" =============================================");
            Console.Write("\n");
            Console.Write(" Nombre Cliente              : ");
            string _nombreCliente = Console.ReadLine();
            //Si esta vacio, termina la función
            if (_nombreCliente.Length == 0) return null;
            Console.Write("  Antiguedad                 : ");
            string _antiguedad_ = Console.ReadLine();
            int _antiguedad = int.TryParse(_antiguedad_, out _) ? Int32.Parse(_antiguedad_) : 0;
            //Solo acepta valores de entre 1 a 10
            if (!(_antiguedad >= 1 && _antiguedad <= 10))
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return null;
            }
            Console.Write("  Nro.Cuenta                 : ");
            string _nrocuenta_ = Console.ReadLine();
            int _nrocuenta = int.TryParse(_nrocuenta_, out _) ? Int32.Parse(_nrocuenta_) : 0;
            //Solo acepta valores de entre 4500 a 9230
            if (!(_nrocuenta >= 4500 && _nrocuenta <= 9230))
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return null;
            }
            Console.Write("  Tipo Ahorro----------------- ");
            //Se elige entre dos opciones: 'A' o 'C'
            Console.Write("\n(A)horro (C)uentaCorriente   : ");
            string _tipoAhorro_ = Console.ReadLine();
            if (_tipoAhorro_.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return null;
            }
            string _tipoAhorro = validarTipo.Contains(_tipoAhorro_) ? _tipoAhorro_ : "";
            if (_tipoAhorro.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return null;
            }
            //Se elige entre dos opciones: 'S' o 'D'
            Console.Write("  Moneda---------------------- ");
            Console.Write("\n(S)oles (D)ólares            : ");
            string _moneda_ = Console.ReadLine();
            if (_moneda_.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return null;
            }
            string _moneda = validarMoneda.Contains(_moneda_) ? _moneda_ : "";
            if (_moneda.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return null;
            }
            Console.Write("  Saldo                      : ");
            string _saldo_ = Console.ReadLine();
            if (_saldo_.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return null;
            }
            double _saldo = double.TryParse(_saldo_, out _) ? double.Parse(_saldo_) : 0;
            //Solo acepta valores de entre 50 a 15000
            if (!(_saldo >= 50 && _saldo <= 15000))
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return null;
            }
            Console.Write("  Token digital              : ");
            string _token_ = Console.ReadLine();
            if (_token_.Length == 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return null;
            }
            int _token = int.TryParse(_token_, out _) ? Int32.Parse(_token_) : 0;
            //Solo acepta valores de entre 1120 a 9999
            if (!(_token >= 1120 && _token <= 9999))
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadLine();
                return null;
            }
            CuentaBanco _cta = new CuentaBanco()
            {
                NombreCliente = _nombreCliente,
                Antiguedad = _antiguedad,
                NumeroCuenta = _nrocuenta,
                TipoCuenta = _tipoAhorro,
                Moneda = _moneda,
                Saldo = _saldo,
                TokenDigital = _token
            };
            return _cta;
        }

        public static void EliminarCuenta()
        {
            Nodoctas.dequeue();
            Console.WriteLine("Cuenta eliminada");
            Console.ReadLine();
            return;
        }

        //Metodo para mostrar todas la cuentas de la COLA
        public static void VisualizarCuenta()
        {

            Console.Clear();
            Console.WriteLine("Cuentas de cliente");
            Console.WriteLine("╔════════════╦══════════════════════════╦════════════════╦══════════════════╦════════════════╦═══════════╦═════════╦═════════╗");
            Console.WriteLine("║  NRO       ║                          ║                ║                  ║      TIPO      ║           ║         ║         ║");
            Console.WriteLine("║  CLIENTE   ║    NOMBRE CLIENTE        ║  ANTIGUEDAD    ║   NRO.CUENTA     ║     CUENTA     ║   MONEDA  ║  SALDO  ║  TOKEN  ║");
            if (Nodoctas.Inicio != null)
            {
                MostrarCuenta(Nodoctas.Inicio);
            }
            Console.WriteLine("╚════════════╩══════════════════════════╩════════════════╩══════════════════╩════════════════╩═══════════╩═════════╩═════════╝");
            Console.ReadLine();

        }
        public static void MostrarCuenta(CuentaBanco unaCta)
        {
            Console.WriteLine("╠════════════╬══════════════════════════╬════════════════╬══════════════════╬════════════════╬═══════════╬═════════╬═════════╣");
            Console.WriteLine("║" + unaCta.NumeroCliente.ToString().PadRight(12, ' ').Substring(0, 12) + "║" +
                              unaCta.NombreCliente.TrimEnd().PadRight(26).Substring(0, 26) + "║" +
                              unaCta.Antiguedad.ToString().PadRight(16, ' ').Substring(0, 16) + "║     " +
                              unaCta.NumeroCuenta.ToString().PadRight(10, ' ').Substring(0, 10) + "   ║" +
                              (unaCta.TipoCuenta == "A" ? "     AHORRO     " : "CUENTA CORRIENTE") + "║   " +
                              (unaCta.Moneda == "S" ? " SOLES  " : "DÓLARES ") + "║" +
                              unaCta.Saldo + "      ║" +
                              unaCta.TokenDigital + "     ║");
            if (unaCta.Sgte != null)
            {
                MostrarCuenta(unaCta.Sgte);
            }
        }
    }
}
