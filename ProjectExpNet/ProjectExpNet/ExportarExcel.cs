using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExpNet
{
    public class ExportarExcel
    {
        public static void ExportarAbas(TabControl tabControl, string diretorioDestino)
        {
            if (!Directory.Exists(diretorioDestino))
            {
                Directory.CreateDirectory(diretorioDestino);
            }

            foreach (TabPage tab in tabControl.TabPages)
            {
                var dgv = tab.Controls.OfType<DataGridView>().FirstOrDefault();

                if (dgv != null && dgv.Rows.Count > 0)
                {
                    string caminhoArquivo = Path.Combine(diretorioDestino, $"{tab.Text}.xlsx");

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add(tab.Text);

                        // Cabeçalhos
                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
                        }

                        // Dados
                        for (int row = 0; row < dgv.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgv.Columns.Count; col++)
                            {
                                worksheet.Cell(row + 2, col + 1).Value = dgv.Rows[row].Cells[col].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(caminhoArquivo);
                    }
                }
            }

            MessageBox.Show("Exportação concluída!", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
