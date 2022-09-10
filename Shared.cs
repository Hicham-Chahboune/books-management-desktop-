using ENSAS_Book.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENSAS_Book
{
    public static class Shared
    {
        public static void AddColumnIcon(DataGridView dgv,string colName,string iconName)
        {
            ResourceManager resourceManager = Resources.ResourceManager;
            Bitmap icon = (Bitmap)resourceManager.GetObject(iconName);
            DataGridViewImageColumn col = new DataGridViewImageColumn
            {
                Name = colName,
                HeaderText = "",
                Image = icon,
                Width = 60,
            };
            col.HeaderCell.Style.Padding = new Padding(20, 0, 20, 0);
            dgv.Columns.Add(col);

        }
        public static bool ConfirmDelete(string msg)
        {
            DialogResult dialogResult = MessageBox.Show(msg, "Delete Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            return (dialogResult == DialogResult.Yes);
        }
        public static byte[] ConvertToBinaryFromFile(string file)
        {
            byte[] bytes;
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
            }
            return bytes;
        }
        public static bool IsNumeric(string input)
        {
            try
            {
                float a = float.Parse(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Validate(ErrorProvider errorProvider,TextBox textBox, string msgError, Button btn,bool isNumeric=false)
        {
            bool condition = (isNumeric) ? (String.IsNullOrEmpty(textBox.Text) || !IsNumeric(textBox.Text)) : String.IsNullOrEmpty(textBox.Text);
            if (condition)
            {
                errorProvider.SetError(textBox, msgError);
                btn.Enabled = false;
                return false;
            }
            else
            {
                errorProvider.Dispose();
                btn.Enabled = true;
                return true;
            }
        }
            }
}
