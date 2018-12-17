using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinglyLinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The top of the list.
        private Cell top = null;

        // Show the values in the list.
        private void ShowValues()
        {
            valuesListBox.Items.Clear();

            // Version 1.
            //Cell current = top;
            //while (current != null)
            //{
            //    valuesListBox.Items.Add(current.Value);
            //    current = current.Next;
            //}

            // Version 2.
            for (Cell current = top; current != null; current = current.Next)
                valuesListBox.Items.Add(current.Value);
        }

        // Add a cell at the top of the list.
        private void addTopButton_Click(object sender, EventArgs e)
        {
            Cell newCell = new Cell();
            newCell.Value = int.Parse(valueTextBox.Text);
            newCell.Next = top;
            top = newCell;

            valueTextBox.Clear();
            ShowValues();
        }

        // Add a value at the bottom of the list.
        private void addBottomButton_Click(object sender, EventArgs e)
        {
            // Find the bottom of the list.
            Cell current = top;
            while (current.Next != null) current = current.Next;

            // Add the item.
            Cell newCell = new Cell();
            newCell.Value = int.Parse(valueTextBox.Text);
            newCell.Next = null;

            current.Next = newCell;

            valueTextBox.Clear();
            ShowValues();
        }

        // Remove the top item.
        private void removeTopButton_Click(object sender, EventArgs e)
        {
            top = top.Next;
            ShowValues();
        }

        // Remove the bottom item.
        private void removeBottomButton_Click(object sender, EventArgs e)
        {
            // Find the bottom of the list.
            Cell before = top;
            while (before.Next.Next != null) before = before.Next;

            // Remove the item after before.
            before.Next = null;

            ShowValues();
        }
    }
}
