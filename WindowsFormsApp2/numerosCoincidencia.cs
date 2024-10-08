using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class NumerosCoincidencia
    {
        List<int> numerosList = new List<int>();
        int numero;

        public void asignar(DataGridView data, int numero) {
            for (int i = 0; i < data.ColumnCount; i++)
            {
                if (data.Rows[0].Cells[i].Value != null && int.TryParse(Convert.ToString(data.Rows[0].Cells[i].Value), out int num))
                {
                    numerosList.Add(num);
                }
            }
            this.numero = numero;   
        }

        public List<int> eliminarCoincidencias()
        {
            for(int i = 0; i < numerosList.Count; i++)
            {
               numerosList.Remove(numero);
            }
            
            return numerosList;
        }

    }
}
