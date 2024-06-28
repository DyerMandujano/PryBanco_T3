using System;
using System.Collections.Generic;
using System.Linq;
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
            get { return _inicio;}
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


    }
}
