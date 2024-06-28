using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Banco_Grupo4
{
    //CLASE DEL NODO CUENTA BANCO
    class NodoCuentaBanco
    {
        //ATRIBUTO PRIVADO DE TIPO CUENTA BANCO
        private CuentaBanco dato;
        //NODO IZQUIERDO
        private NodoCuentaBanco n_izq;
        //NODO DERECHO
        private NodoCuentaBanco n_der;
        

        //CONSTRUCTOR CON PARAMETRO
        public NodoCuentaBanco( CuentaBanco data)
        {
            Dato = data;
            //INICIALIZAMOS LOS NODOS CON NULL
            N_Izq = null;
            N_Der = null;
            

        }

        //Propiedades
        public CuentaBanco Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public NodoCuentaBanco N_Izq
        {
            get { return n_izq; }
            set { n_izq = value; }
        }

        public NodoCuentaBanco N_Der
        {
            get { return n_der; }
            set { n_der = value; }
        }
        

    }
}
