using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class ManejadorLista
    {
        private List<int> lista = new List<int>();

        public void AgregarElemento(int elemento)
        {
            lista.Add(elemento);
        }

        public void EliminarElemento()
        {
            try
            {
                if (lista.Count == 0)
                {
                    throw new InvalidOperationException("Operacion invalida en lista vacia");
                }

                lista.RemoveAt(lista.Count - 1);
                Console.WriteLine("Elemento eliminado correctamente.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin del proceso.");
            }
        }
    }
}
