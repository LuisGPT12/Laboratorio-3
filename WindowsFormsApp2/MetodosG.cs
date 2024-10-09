
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public static class MetodosG
{

    public static void flitrar(List<double> importes, DataGridView dgv)
    {
        
        if (importes.Count >= 5)
        {
            var importesFiltrados = importes.Where(i => i >= 50 && i <= 287)
                .OrderBy(i => i)
                .ToList();

            dgv.DataSource = importesFiltrados
                .Select(i => new { Importe = i })
                .ToList();
        }
        else
        {
            MessageBox.Show("Disculpe, pero aún no se han insertado suficientes datos. El mínimo es 5.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}