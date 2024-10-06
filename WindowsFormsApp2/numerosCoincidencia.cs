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
        public void eliminarC(ref DataGridView d, int numero)
        {

            int cantidad = d.ColumnCount;
            int num, indice;
           
            for (int i = 0; i < cantidad; i++)
            {
                if (d.Rows[0].Cells[i].Value != null && int.TryParse(Convert.ToString(d.Rows[0].Cells[i].Value), out num))
                {
                   numeros.Add(num);
                }
                
            } 
            indice = numeros.Count-1;
            for(int i = 0; i < indice; i++)
            {
                if (numeros[i] == numero) {
                    numeros.RemoveAt(i);
                }
            }
            indice = numeros.Count;
            d.Columns.Clear();
            d.Rows.Clear();
            d.RowCount = 1;
            d.ColumnCount=indice;

            for (int i = 0; i < indice; i++)
            {
                d.Rows[0].Cells[i].Value = numeros[i].ToString();
            }

        }


        
     
    }
}
