using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangularArray
{
    public class TriangularArray<T>
    {
        // The number of rows in the square array.
        public int NumRows = 0;

        // The storage array.
        public T[] Values = null;

        // Constructor.
        public TriangularArray(int numRows)
        {
            NumRows = numRows;
            Values = new T[NumRows * (NumRows - 1) / 2];
        }

        // Map a row and column to a storage array index.
        public int MapRowColumn(int row, int column)
        {
            // Make sure the indices make sense.
            if (row == column) throw new ArgumentException("The row and column indexes cannot be the same");
            if (row >= NumRows) throw new ArgumentException("The row must be smaller than the number of rows");
            if (column >= NumRows) throw new ArgumentException("The column must be smaller than the number of rows");

            // If row < column, switch them.
            if (row < column)
            {
                int temp = row;
                row = column;
                column = temp;
            }

            return row * (row - 1) / 2 + column;
        }

        // Set an entry.
        public void SetValue(T value, int row, int column)
        {
            Values[MapRowColumn(row, column)] = value;
        }

        // Get an entry.
        public T GetValue(int row, int column)
        {
            return Values[MapRowColumn(row, column)];
        }
    }
}
