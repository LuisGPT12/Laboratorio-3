using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class numerosCoincidencia
    {
        List<int> numeros = new List<int>();
        int numero;


        public void asignar(DataGridView d, int numero) {
            int num, cantidad = d.ColumnCount;

            for (int i = 0; i < cantidad; i++)
            {
                if (d.Rows[0].Cells[i].Value != null && int.TryParse(Convert.ToString(d.Rows[0].Cells[i].Value), out num))
                {
                    numeros.Add(num);
                }
            }
            this.numero = numero;   
        }

        public List<int> eliminarC()
        {
            int indice;
            indice = numeros.Count;
            for(int i = 0; i < indice; i++)
            {
               numeros.Remove(numero);
            }
            
            return numeros;
        }

    }
}
