using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesBinarios
{
    internal class ArbolBinario
    {

        public Nodo Raiz { get; private set; }

        // Insertar un nuevo nodo
        public void Insertar(int valor)
        {
            Raiz = InsertarRecursivo(Raiz, valor);
        }

        private Nodo InsertarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
                return new Nodo(valor);

            if (valor < nodo.Valor)
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
            else if (valor > nodo.Valor)
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);

            return nodo;
        }

        // Buscar un nodo
        public bool Buscar(int valor)
        {
            return BuscarRecursivo(Raiz, valor);
        }

        private bool BuscarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
                return false;

            if (valor == nodo.Valor)
                return true;

            if (valor < nodo.Valor)
                return BuscarRecursivo(nodo.Izquierdo, valor);
            else
                return BuscarRecursivo(nodo.Derecho, valor);
        }

        // Eliminar un nodo
        public void Eliminar(int valor)
        {
            Raiz = EliminarRecursivo(Raiz, valor);
        }

        private Nodo EliminarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
                return null;

            if (valor < nodo.Valor)
                nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, valor);
            else if (valor > nodo.Valor)
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, valor);
            else
            {
                if (nodo.Izquierdo == null)
                    return nodo.Derecho;
                else if (nodo.Derecho == null)
                    return nodo.Izquierdo;

                nodo.Valor = MinimoValor(nodo.Derecho);
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, nodo.Valor);
            }

            return nodo;
        }

        private int MinimoValor(Nodo nodo)
        {
            int minimo = nodo.Valor;
            while (nodo.Izquierdo != null)
            {
                minimo = nodo.Izquierdo.Valor;
                nodo = nodo.Izquierdo;
            }
            return minimo;
        }

        // Recorridos
        public string InOrden()
        {
            return RecorrerInOrden(Raiz).Trim();
        }

        private string RecorrerInOrden(Nodo nodo)
        {
            if (nodo == null) return "";

            return RecorrerInOrden(nodo.Izquierdo) +
                   nodo.Valor + " " +
                   RecorrerInOrden(nodo.Derecho);
        }

    }
}
