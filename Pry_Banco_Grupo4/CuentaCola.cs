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

        public void dequeue()
        {
            _inicio = _inicio.Sgte;
        }

        public CuentaBanco Inicio
        {
            get { return _inicio; }
        }
    }
}
