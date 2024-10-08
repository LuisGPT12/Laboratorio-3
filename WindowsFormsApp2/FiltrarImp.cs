using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class FiltrarImp
    {
        private List<Double> importes = new List<Double>();

        public void asignar(Double imp)
        {
            importes.Add(imp);
        }

        public Boolean validarMinimo()
        {
            return importes.Count >= 5;
        }

        public List<Double> filtrarImportes()
        {
            List<double> resultFiltrado = new List<double>();

            for (int i = 0; i < importes.Count; i++)
            {
                if (importes[i] >= 50 && importes[i] <= 287)
                {
                    resultFiltrado.Add(importes[i]);
                }
            }
            resultFiltrado.Sort();
            if (resultFiltrado.Count == 0)
            {
                MessageBox.Show("No hay datos registrados de Importes Mayores a 58 y Menores 287", "¡Aviso!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return resultFiltrado;
        }

        public double get(int posicion)
        {
            return importes[posicion];
        }
    }
}
