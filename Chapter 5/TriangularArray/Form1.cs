using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangularArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The array.
        private TriangularArray<string> TheArray = null;

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numRows = int.Parse(numRowsTextBox.Text);
                TheArray = new TriangularArray<string>(numRows);

                // Initialize all values to empry strings not null (for display).
                for (int row = 0; row < numRows - 1; row++)
                {
                    for (int column = row + 1; column < numRows; column++)
                    {
                        TheArray.SetValue("", row, column);
                    }
                }

                getButton.Enabled = true;
                setButton.Enabled = true;

                Dump();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Set a value.
        private void setButton_Click(object sender, EventArgs e)
        {
            try
            {

                int row = int.Parse(rowTextBox.Text);
                int column = int.Parse(columnTextBox.Text);
                TheArray.SetValue(valueTextBox.Text, row, column);

                valueTextBox.Clear();
                Dump();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Get a value.
        private void getButton_Click(object sender, EventArgs e)
        {
            try
            {
                int row = int.Parse(rowTextBox.Text);
                int column = int.Parse(columnTextBox.Text);
                valueTextBox.Text = TheArray.GetValue(row, column);

                Dump();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Dump the array's contents.
        public void Dump()
        {
            valuesListBox.Items.Clear();
            foreach (string value in TheArray.Values)
                valuesListBox.Items.Add(value.ToString());
        }
    }
}
