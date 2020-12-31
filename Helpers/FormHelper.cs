using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Helpers
{
    class FormHelper
    {
        public string ReplaceFieldnames(string message, Dictionary<string, string> replacers)
        {
            foreach (KeyValuePair<string, string> kvp in replacers)
            {
                message = message.Replace(kvp.Key, kvp.Value);
            }

            return message;
        }

        public int FindColumnIndex(DataGridView table, string name)
        {
            int index = -1;
            foreach (DataGridViewColumn column in table.Columns)
            {
                if (String.Equals(column.Name, name))
                {
                    index = column.Index;
                    break;
                }
            }
            return index;
        }

        public int FindIndex(DataGridView table, int id)
        {
            int rowIndex = -1;
            int columnIndex = this.FindColumnIndex(table, "id");
            if (columnIndex == -1)
            {
                return rowIndex;
            }

            foreach (DataGridViewRow row in table.Rows)
            {
                if (String.Equals(id.ToString(), row.Cells[columnIndex].Value.ToString()))
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            return rowIndex;
        }
    }
}
