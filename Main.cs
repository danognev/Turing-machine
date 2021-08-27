using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            fillTape();
        }
        int countColCond = 0;
        int nameColCond = 0;
        int condInd = 0;
        private void fillTape()
        {
            tableTape.Columns.Clear();
            for (int i = 0; i < 100; i++)
            {
                tableTape.Columns.Add($"{i}", $"{i + 1}");
                tableTape.Columns[i].Width = 40;
                tableTape.Columns[i].ReadOnly = false;
            }
            tableTape.Rows.Add();
            Console.WriteLine(tableTape.ColumnCount);
        }

        private void addCond_Click(object sender, EventArgs e)
        {
            condTable.Columns.Add($"Q{nameColCond}", "Q" + (countColCond + 2));
            countColCond++;
            nameColCond++;
        }

        private void alphabetText_TextChanged(object sender, EventArgs e)
        {
            condTable.Rows.Clear();
            string alphaStr = alphabetText.Text;
            for (int i = 0; i < alphaStr.Length; i++)
            {
                condTable.Rows.Add();
                condTable.Rows[i].HeaderCell.Value = string.Format(alphaStr[i].ToString(), "0");
            }
            for (int i = 0; i < condTable.ColumnCount; i++)
            {
                condTable.Columns[i].ReadOnly = false;
            }
        }

        private void stepBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableTape.CurrentCell.Selected)
                {
                    if (!string.IsNullOrEmpty(tableTape.CurrentCell.Value.ToString()))
                    {
                        for (int i = 0; i < condTable.RowCount; i++)
                        {
                            if (condTable.Rows[i].HeaderCell.Value.ToString().Contains(tableTape.CurrentCell.Value.ToString()))
                            {
                                condTable.CurrentCell.Style.BackColor = Color.Empty;
                                string temp = condTable[condInd, i].Value.ToString();
                                if (!temp.Contains(">") && !temp.Contains("<"))
                                {
                                    tableTape.CurrentCell.Value = temp;
                                    int x = tableTape.CurrentCell.ColumnIndex;
                                    int y = tableTape.CurrentCell.RowIndex;
                                    tableTape[x, y].Style.BackColor = Color.LightBlue;
                                    tableTape[x + 1, y].Selected = true;
                                    condTable[condInd, i].Selected = true;
                                }
                                else if (temp.Contains(">"))
                                {
                                    tableTape.CurrentCell.Value = temp.Remove(temp.IndexOf('>'));
                                    int x = tableTape.CurrentCell.ColumnIndex;
                                    int y = tableTape.CurrentCell.RowIndex;
                                    tableTape[x, y].Style.BackColor = Color.LightBlue;
                                    tableTape[x + 1, y].Selected = true;
                                    condInd = temp.Last() - '0';
                                    condTable[condInd, i].Selected = true;
                                }
                                else if (temp.Contains("<"))
                                {
                                    if (tableTape.CurrentCell.ColumnIndex != 0)
                                    {
                                        tableTape.CurrentCell.Value = temp.Remove(temp.IndexOf('<'));
                                        int x = tableTape.CurrentCell.ColumnIndex;
                                        int y = tableTape.CurrentCell.RowIndex;
                                        tableTape[x, y].Style.BackColor = Color.LightYellow;
                                        tableTape[x - 1, y].Selected = true;
                                        condInd = temp.Last() - '0';
                                        condTable[condInd, i].Selected = true;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка выполнения!");
                condInd = 0;
            }
        }

        private void startBttn_Click(object sender, EventArgs e)
        {
            try
            {
                int i = tableTape.CurrentCell.ColumnIndex;
                while (!string.IsNullOrEmpty(tableTape[i, 0].Value.ToString()))
                {
                    for (int j = 0; j < condTable.RowCount; j++)
                    {
                        if (condTable.Rows[j].HeaderCell.Value.ToString().Contains(tableTape.CurrentCell.Value.ToString()))
                        {
                            string temp = condTable[condInd, j].Value.ToString();
                            if (!temp.Contains(">") && !temp.Contains("<"))
                            {
                                tableTape.CurrentCell.Value = temp;
                                int x = tableTape.CurrentCell.ColumnIndex;
                                int y = tableTape.CurrentCell.RowIndex;
                                tableTape[x, y].Style.BackColor = Color.LightBlue;
                                tableTape[x + 1, y].Selected = true;
                                i++;
                            }
                            else if (temp.Contains(">"))
                            {
                                tableTape.CurrentCell.Value = temp.Remove(temp.IndexOf('>'));
                                int x = tableTape.CurrentCell.ColumnIndex;
                                int y = tableTape.CurrentCell.RowIndex;
                                tableTape[x, y].Style.BackColor = Color.LightBlue;
                                tableTape[x + 1, y].Selected = true;
                                condInd = temp.Last() - '0';
                                i++;
                            }
                            else if (temp.Contains("<"))
                            {
                                tableTape.CurrentCell.Value = temp.Remove(temp.IndexOf('<'));
                                int x = tableTape.CurrentCell.ColumnIndex;
                                int y = tableTape.CurrentCell.RowIndex;
                                tableTape[x, y].Style.BackColor = Color.LightYellow;
                                i--;
                                if (x != 0)
                                {
                                    tableTape[x - 1, y].Selected = true;
                                    condInd = temp.Last() - '0';
                                }
                                else
                                    break;
                            }
                            break;
                        }
                    }
                }
                condInd = 0;
            }
            catch
            {
                MessageBox.Show("Программа выполнена!");
                condInd = 0;
            }
        }

        private void deleteCond_Click(object sender, EventArgs e)
        {
            condTable.Columns.RemoveAt(condTable.ColumnCount - 1);
            countColCond--;
            nameColCond--;
        }

        private void cursorToLeft_Click(object sender, EventArgs e)
        {
            try
            {
                tableTape[tableTape.CurrentCell.ColumnIndex - 1, 0].Selected = true;
            }
            catch { }
        }

        private void cursorToRight_Click(object sender, EventArgs e)
        {
            try
            {
                tableTape[tableTape.CurrentCell.ColumnIndex + 1, 0].Selected = true;
            }
            catch { }
        }

        private void resetBttn_Click(object sender, EventArgs e)
        {
            fillTape();
            alphabetText.Clear();
            condInd = 0;
        }

    private void tableTape_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
