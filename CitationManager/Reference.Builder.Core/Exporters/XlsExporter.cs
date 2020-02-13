using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reference.Builder.Core.Exporters
{
    public class XlsExporter : IExporter
    {
        public XlsExporter()
        {

        }

        public void Export(ListView itemList)
        {
            // Refactor this
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook| * .xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Citation";
                    int i = 2;
                    foreach (ListViewItem item in itemList.Items)
                    {
                        ws.Cells[i, 1] = item.Text;
                        i++;
                    }

                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Citation list successfully exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
