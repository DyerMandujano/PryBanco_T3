using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Banco_Grupo4
{
    class ArbolCuentaBanco
    {
        //ATRIBUTO PRIVADO
        private NodoCuentaBanco arbol_cuenta_cli;
        
        //PROPIEDAD
        public NodoCuentaBanco Arbol_Cuenta_Cliente
        {
            get { return arbol_cuenta_cli;}
            set { arbol_cuenta_cli = value;}
        }
        
        public ArbolCuentaBanco()
        {
            //INICIALIZAMOS CON NULL AL ARBOL
            Arbol_Cuenta_Cliente = null;
        }

        public void insertaNodo(CuentaBanco new_cuenta)
        {
            //La variable valorRaiz será el valor base en donde cada vez que se ingresa un nodo, se compará con está
            int valorRaiz;
            //Instanciamos el nuevo nodo que se va a ingresar
            NodoCuentaBanco q = new NodoCuentaBanco(new_cuenta);
            //Creamos el objeto 't' que nos servirá para recorrer el Arbol
            NodoCuentaBanco t = Arbol_Cuenta_Cliente;
            //Esta variable nos permite saber el nivel o altura en donde se encuentra cada nodo
            int alt_arb = 0;


            //Si el arbol es null
            if (Arbol_Cuenta_Cliente == null)
            {
                //Agrega el nuevo nodo al arbol
                Arbol_Cuenta_Cliente = q;
            }
            //De lo contrario
            else
            {
                //Mientras el objeto 't' sea diferente de null
                while (t != null)
                {
                    //La variable 'alt_arb' aumenta en 1
                    alt_arb++;
                    //En 'valorRaiz' almacenamos el valor base o primer valor que se encuentra en el arbol
                    //para luego poder realizar las comparaciones.
                    valorRaiz = t.Dato.NumeroCliente;

                    //Si la propiedad NumeroCliente del nuevo objeto 'new_cuenta' es menor al 'valorRaiz'
                    if (new_cuenta.NumeroCliente < valorRaiz)
                    {
                        //NOTA: Y por Teoria de Arboles, SI UN OBJETO ES MENOR SE VA PARA LA IZQUIERDA
                        //Ahora, si el nodoIzquierdo es diferente de null
                        if (t.N_Izq != null)
                        {
                            //entonces el t apunta al nodo izquierdo (Hasta encontrar una posición vacia, es decir hasta que sea null)
                            //Es decir, el objeto 't' almacenará todo los valores del objeto que se encuentra en el NodoIzquierdo
                            t = t.N_Izq;
                            //luego de la linea de codigo 63, entrará nuevamente al While ya que el 't' al tener los valores del objeto 'N_Izquierda'
                            //seguirá siendo diferente de 'null'.
                        }
                        //De lo contrario
                        //Si ya encontró una posición vacia, es decir que el 't.N_Izq == null'
                        else
                        {
                            //Le colocamos el valor de la variable 'alt_arb' a la propiedad Altura_Arb del nuevo Nodo 'q'
                            q.Dato.Altura_Arb = alt_arb;
                            //Se ingresa el nuevo nodo 'q' allí 
                            t.N_Izq = q;
                            //Y termina la función
                            return;
                        }
                    }
                    //De lo contrario, Si el nuevo objeto 'new_mant' es mayor o igual que el 'valorRaiz' 
                    else
                    {
                        //NOTA: Y por Teoria de Arboles, SI UN OBJETO ES MAYOR O IGUAL SE VA PARA LA DERECHA
                        //Ahora, si el nodoDerecho es diferente de null
                        if (t.N_Der != null)
                        {
                            //entonces el t apunta al nodo derecho (Hasta encontrar una posición vacia, es decir hasta que sea null)
                            //Es decir, el objeto 't' almacenará todo los valores del objeto que se encuentra en el NodoDerecho
                            t = t.N_Der;
                            //luego de la linea de codigo 87, entrará nuevamente al While ya que el 't' al tener los valores del objeto 'N_Der'
                            //seguirá siendo diferente de 'null'.
                        }
                        //De lo contrario
                        //Si ya encontró una posición vacia, es decir que el 't.N_Der == null'
                        else
                        {
                            //Le colocamos el valor de la variable 'alt_arb' a la propiedad Altura_Arb del nuevo Nodo 'q'
                            q.Dato.Altura_Arb = alt_arb;
                            //Se ingresa el nuevo nodo 'q' allí 
                            t.N_Der = q;
                            //Y termina la función
                            return;
                        }
                    }
                }
            }
        }

        //METODO PARA MOSTRAR TODO EL ARBOL
        public void muestraArbol(NodoCuentaBanco arbol, int cont)
        {
            if (arbol == null)
            {
                return;
            }
            else
            {
                muestraArbol(arbol.N_Der, cont + 1);
                for (int i = 0; i < cont; i++)
                {
                    Console.Write("      ");
                }
                Console.WriteLine(arbol.Dato.NumeroCliente + "." + arbol.Dato.NombreCliente);
                muestraArbol(arbol.N_Izq, cont + 1);
            }
        }

        //Este Metodo sirve para encontrar el Valor MAS PEQUEÑO DEL ARBOL
        //Es decir, que por teoria de arboles binarios el valor mas pequeño es el que se encuentra
        //más a la Izquieda del arbol.
        public NodoCuentaBanco BuscarMin(NodoCuentaBanco pNodo)
        {
            if (pNodo.N_Izq == null)
            {
                return pNodo;
            }
            return BuscarMin(pNodo.N_Izq);
        }

        //METODO PARA ELIMINAR CUENTA CLIENTE MEDIANTE IDCLIENTE
        public NodoCuentaBanco Delete(NodoCuentaBanco pNodo, int idCli)
        {

            //Si el 'pNodo' es null
            if (pNodo == null)
            {
                //retorna el 'pNodo'
                return pNodo;
            }

            //Si el idCli es menor al valor de la propiedad NumeroCliente
            if (idCli < pNodo.Dato.NumeroCliente)
            {
                //Realiza metodo recursivo en el Nodo Izquierdo
                pNodo.N_Izq = Delete(pNodo.N_Izq, idCli);
            }

            //Si el idCli es mayor al valor de la propiedad NumeroCliente
            if (idCli > pNodo.Dato.NumeroCliente)
            {
                //Realiza metodo recursivo en el Nodo Derecho
                pNodo.N_Der = Delete(pNodo.N_Der, idCli);
            }

            //De lo contrario Si el NodoIzq es null y el idCli es igual que el valor de la propiedad NumeroCliente
            else if (pNodo.N_Izq == null && idCli == pNodo.Dato.NumeroCliente)
            {
                //Se crea un objeto temp de tipo NodoCuentaBanco que almacenará el NodoDer
                NodoCuentaBanco temp = pNodo.N_Der;
                //El NodoDer se elimina
                pNodo.N_Der = null;
                //retorna el objeto 'temp'
                return temp;
            }

            //De lo contrario Si el NodoDer es null y el idCli es igual que el valor de la propiedad NumeroCliente
            else if (pNodo.N_Der == null && idCli == pNodo.Dato.NumeroCliente)
            {
                //Se crea un objeto 'temp' de tipo NodoCuentaBanco que almacenará el NodoIzq
                NodoCuentaBanco temp = pNodo.N_Izq;
                //El NodoIzq se elimina
                pNodo.N_Izq = null;
                //retorna el objeto 'temp'
                return temp;
            }

            //De lo contrario Si el NodoDer y el NodoIzq son diferentes de null
            //y el idCli es igual que el valor de la propiedad NumeroCliente
            else if (pNodo.N_Der != null && pNodo.N_Izq != null && idCli == pNodo.Dato.NumeroCliente)
            {
                //Creamos un objeto 'min' el cual almacenará el valor de retorno que nos da el metodo BuscarMin
                NodoCuentaBanco min = BuscarMin(pNodo.N_Der);
                //La propiedad NumeroCliente almacenará el valor del NumeroCliente del objeto 'min'
                pNodo.Dato.NumeroCliente = min.Dato.NumeroCliente;
                //Se realiza metodo recursivo de 'Delete' por el NodoDer y ese valor se almacena en el 'pNodo.N_Der'
                pNodo.N_Der = Delete(pNodo.N_Der, min.Dato.NumeroCliente);
            }
            //RETORNA 'pNodo'
            return pNodo;
        }

        public void ActualizarCuentaCliente(int idCli, CuentaBanco update_cta_cli)
        {
            int valorRaiz;
            NodoCuentaBanco t = Arbol_Cuenta_Cliente;

            if (Arbol_Cuenta_Cliente == null)
            {
                return;
            }
            else
            {
                while (t != null)
                {
                    //En 'valorRaiz' almacenamos el valor base o primer valor que se encuentra en el arbol
                    valorRaiz = t.Dato.NumeroCliente;
                    //Si el valor pasado por parametro 'buscar_mant' es IGUAL al valorRaiz
                    if (idCli == valorRaiz)
                    {
                        t.Dato = update_cta_cli;
                        update_cta_cli.NumeroCliente = idCli;
                        return;
                    }
                    //Si el valor pasado por parametro 'buscar_mant' se encuentrá antes (-1) que el 'valorRaiz' de forma alfabetica
                    else if (idCli < valorRaiz)
                    {
                        //Ahora, si el nodoIzquierdo es diferente de null
                        if (t.N_Izq != null)
                        {
                            //entonces el t apunta al nodo izquierdo (Hasta encontrar una posición vacia, es decir hasta que sea null)
                            //Es decir, el objeto 't' almacenará todo los valores del objeto que se encuentra en el NodoIzquierdo
                            t = t.N_Izq;
                        }
                        //De lo contrario
                        //Si ya recorrio todo ese lado, es decir que el 't.N_Izq == null'
                        else
                        {
                            //Entonces no se encuentra.
                            Console.WriteLine("El Id " + idCli + " NO se encuentra en el arbol!!");
                            //Termina el programa
                            return;
                        }
                    }
                    //De lo contrario, Si el valor 'buscar_mant' es posterior que el 'valorRaiz' de forma alfabetica
                    else
                    {
                        //Ahora, si el nodoDerecho es diferente de null
                        if (t.N_Der != null)
                        {
                            //entonces el t apunta al nodo derecho (Hasta encontrar una posición vacia, es decir hasta que sea null)
                            //Es decir, el objeto 't' almacenará todo los valores del objeto que se encuentra en el NodoDerecho
                            t = t.N_Der;
                            //luego de la linea de codigo 189, entrará nuevamente al While ya que el 't' al tener los valores del objeto 'N_Der'
                            //seguirá siendo diferente de 'null'.
                        }
                        //De lo contrario
                        //Si ya recorrio todo ese lado, es decir que el 't.N_Der == null'
                        else
                        {
                            //Entonces no se encuentra.
                            Console.WriteLine("El Id " + idCli + " NO se encuentra en el arbol!!");
                            //Termina el programa
                            return;
                        }
                    }
                }
            }
        }

        public bool busquedaPorNumCliente(int idCli)
        {
            int valorRaiz;
            NodoCuentaBanco t = Arbol_Cuenta_Cliente;

            if (Arbol_Cuenta_Cliente == null)
            {
                return false;
            }
            else
            {
                bool flag = false;
                while (t != null)
                {
                    //En 'valorRaiz' almacenamos el valor base o primer valor que se encuentra en el arbol
                    valorRaiz = t.Dato.NumeroCliente;
                    //Si el valor pasado por parametro 'buscar_mant' es IGUAL al valorRaiz
                    if (idCli == valorRaiz)
                    {
                        //Imprime lo siguiente en consola
                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║  CUENTA CLIENTE                    ║");
                        Console.WriteLine("╚════════════════════════════════════╝");
                        Console.WriteLine(" Num Cliente: " + t.Dato.NumeroCliente);
                        Console.WriteLine(" Nombre: " + t.Dato.NombreCliente);
                        Console.WriteLine(" Antiguedad: " + t.Dato.Antiguedad);
                        Console.WriteLine(" Num Cuenta: " + t.Dato.NumeroCuenta);
                        string tp = t.Dato.TipoCuenta == "AHORRO" ? " AHORRO" : " CUENTA CORRIENTE";
                        Console.WriteLine(" Tipo Cuenta:" + tp);
                        string tm = t.Dato.Moneda == "SOLES" ? " SOLES" : " DÓLARES ";
                        Console.WriteLine(" Moneda: " + tm);
                        Console.WriteLine(" Saldo: " + t.Dato.Saldo);
                        Console.WriteLine(" Token: " + t.Dato.TokenDigital);
                        //Console.WriteLine("╚════════════╩═══════════════════════╝");
                        flag = true;
                        return flag;
                    }
                    //Si el valor pasado por parametro 'buscar_mant' se encuentrá antes (-1) que el 'valorRaiz' de forma alfabetica
                    else if (idCli < valorRaiz)
                    {
                        //Ahora, si el nodoIzquierdo es diferente de null
                        if (t.N_Izq != null)
                        {
                            //entonces el t apunta al nodo izquierdo (Hasta encontrar una posición vacia, es decir hasta que sea null)
                            //Es decir, el objeto 't' almacenará todo los valores del objeto que se encuentra en el NodoIzquierdo
                            t = t.N_Izq;
                        }
                        //De lo contrario
                        //Si ya recorrio todo ese lado, es decir que el 't.N_Izq == null'
                        else
                        {
                            //Entonces no se encuentra.
                            Console.WriteLine("El Id " + idCli + " NO se encuentra en el arbol!!");
                            //Termina el programa
                            flag = false;
                            return flag;
                        }
                    }
                    //De lo contrario, Si el valor 'buscar_mant' es posterior que el 'valorRaiz' de forma alfabetica
                    else
                    {
                        //Ahora, si el nodoDerecho es diferente de null
                        if (t.N_Der != null)
                        {
                            //entonces el t apunta al nodo derecho (Hasta encontrar una posición vacia, es decir hasta que sea null)
                            //Es decir, el objeto 't' almacenará todo los valores del objeto que se encuentra en el NodoDerecho
                            t = t.N_Der;
                            //luego de la linea de codigo 189, entrará nuevamente al While ya que el 't' al tener los valores del objeto 'N_Der'
                            //seguirá siendo diferente de 'null'.
                        }
                        //De lo contrario
                        //Si ya recorrio todo ese lado, es decir que el 't.N_Der == null'
                        else
                        {
                            //Entonces no se encuentra.
                            Console.WriteLine("El Id " + idCli + " NO se encuentra en el arbol!!");
                            //Termina el programa
                            flag = false;
                            return flag;
                        }
                    }
                }
                return flag;
            }
        }

        //Metodo Para Calcular la Altura
        public int CalcularAltura(NodoCuentaBanco nodoC)
        {
            //Si el 'nodoC' ES NULL (Es decir, porque puede que se encuentre en la hoja o porque el arbol está vacio)
            if (nodoC == null)
                //retorna 0
                return 0; 
            //De lo contrario
            else
            {
                //se realiza recursividad 
                //Creamos una variable 'altIzq' en el cual almacenaremos el valor que nos retornará
                //el metodo recursivo 'CalcularAltura' que se hará por el subArbol Izquierdo
                int altIzq = CalcularAltura(nodoC.N_Izq);

                //Creamos una variable 'altDer' en el cual almacenaremos el valor que nos retornará
                //el metodo recursivo 'CalcularAltura' que se hará por el subArbol Izquierdo
                int altDer = CalcularAltura(nodoC.N_Der);
                //El metodo Max nos devuelve el valor max que hay entre la altIzq y Derecha
                //y a ello le sumamos 1
                return 1 + Math.Max(altIzq, altDer);
            }
            
        }

        //Metodo para mostrar el arbol en PostOrden
        //PostOrden : Arbol Izquierdo - Arbol Derecho - Raiz
        public void postOrden(NodoCuentaBanco arbol)
        {
            //Si el arbol no es nulo
            if (arbol != null)
            {
                //Mostrar el arbol por la izquierda
                postOrden(arbol.N_Izq);
                //Mostrar el arbol por la derecha
                postOrden(arbol.N_Der);
                //Mostrar la Raiz
                //Imprime lo siguiente en consola
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║ CUENTA CLIENTE                     ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                Console.WriteLine(" Num Cliente: " + arbol.Dato.NumeroCliente);
                Console.WriteLine(" Nombre: " + arbol.Dato.NombreCliente);
                Console.WriteLine(" Antiguedad: " + arbol.Dato.Antiguedad);
                Console.WriteLine(" Num Cuenta: " + arbol.Dato.NumeroCuenta);
                string tp = arbol.Dato.TipoCuenta == "AHORRO" ? " AHORRO" : " CUENTA CORRIENTE";
                Console.WriteLine(" Tipo Cuenta:" + tp);
                string tm = arbol.Dato.Moneda == "SOLES" ? " SOLES" : " DÓLARES ";
                Console.WriteLine(" Moneda: " + tm);
                Console.WriteLine(" Saldo: " + arbol.Dato.Saldo);
                Console.WriteLine(" Token: " + arbol.Dato.TokenDigital);
            }
        }










        /*
        public int CalcularAltura()
        {
            if (Arbol_Cuenta_Cliente == null)
                return 0; // Árbol vacío

            Queue<NodoCuentaBanco> ColaNodoC = new Queue<NodoCuentaBanco>();
            ColaNodoC.Enqueue(Arbol_Cuenta_Cliente);
            int altura = 0;

            while (ColaNodoC.Count > 0)
            {
                int nivelSize = ColaNodoC.Count;

                for (int i = 0; i < nivelSize; i++)
                {
                    NodoCuentaBanco nodoActual = ColaNodoC.Dequeue();

                    if (nodoActual.N_Izq != null)
                        ColaNodoC.Enqueue(nodoActual.N_Izq);

                    if (nodoActual.N_Der != null)
                        ColaNodoC.Enqueue(nodoActual.N_Der);
                }
                altura++;
            }
            return altura - 1;
        }
        */
    }
}
