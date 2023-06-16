using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TGMTcs
{
    public class TGMTform
    {
        public static void UnselectDatagridview(DataGridView grid_data)
        {
            if (grid_data.RowCount > 0 && grid_data.ColumnCount > 0)
            {
                grid_data.CurrentCell = grid_data[0, 0];
                grid_data.CurrentCell.Selected = false;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void MoveCaretToEnd(ComboBox cb)
        {
            if (cb.Text != "")
            {
                cb.SelectionStart = cb.Text.Length;
                cb.SelectionLength = 0;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void MoveCaretToEnd(TextBox txt)
        {
            if (txt.Text != "")
            {
                txt.SelectionStart = txt.Text.Length;
                txt.SelectionLength = 0;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void FormatGrid(DataGridView grid, string[] columns)
        {
            foreach (string c in columns)
            {
                grid.Columns[c].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid.Columns[c].DefaultCellStyle.Format = "N0";
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void OnlyInputNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //on key up event
        public static void FormatDelimiter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                return;


            TextBox textbox = (TextBox)sender;
            string text = textbox.Text.Replace(",", "");
            if (text == "")
                return;

            int selectionStart = textbox.SelectionStart;
            long number = Convert.ToInt64(text);
            textbox.Text = number.ToString("N0");

            textbox.SelectionStart = selectionStart;
            textbox.SelectionLength = 0;
        }
    }
}

    

