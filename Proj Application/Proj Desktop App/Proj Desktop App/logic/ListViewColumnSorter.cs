using System;
using System.Collections;
using System.Windows.Forms;

namespace Proj_Desktop_App.logic
{
    class ListViewColumnSorter : IComparer
    {
        /// <summary>
        /// Specifies the column to be sorted
        /// </summary>
        private int columnToSort;

        /// <summary>
        /// Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
        /// </summary>
        public int SortColumn
        {
            set
            {
                columnToSort = value;
            }
            get
            {
                return columnToSort;
            }
        }

        /// <summary>
        /// Specifies the order in which to sort (i.e. 'Ascending').
        /// </summary>
        private SortOrder orderOfSort;

        /// <summary>
        /// Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
        /// </summary>
        public SortOrder Order
        {
            set
            {
                orderOfSort = value;
            }
            get
            {
                return orderOfSort;
            }
        }

        private Type columnType;

        /// <summary>
        /// Gets or sets the type of the column to be sorted (int, double or string).
        /// </summary>
        public Type SortType
        {
            set
            {
                columnType = value;
            }
            get
            {
                return columnType;
            }
        }

        /// <summary>
        /// Case insensitive comparer object
        /// </summary>
        private IComparer ObjectCompare;

        /// <summary>
        /// Class constructor. Initializes various elements
        /// </summary>
        public ListViewColumnSorter()
        {
            // Initialize the column to '0'
            columnToSort = 0;

            // Initialize the sort order to 'none'
            orderOfSort = SortOrder.Ascending;

            // Initialize the CaseInsensitiveComparer object
            ObjectCompare = new CaseInsensitiveComparer();

            columnType = typeof(string);
        }

        /// <summary>
        /// This method is inherited from the IComparer interface. It compares the two objects passed using a case insensitive comparison.
        /// </summary>
        /// <param name="x">First object to be compared</param>
        /// <param name="y">Second object to be compared</param>
        /// <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            //Compare the two
            if (columnType == typeof(int))
            {
                compareResult = Convert.ToInt32(listviewX.SubItems[columnToSort].Text).CompareTo(Convert.ToInt32(listviewY.SubItems[columnToSort].Text));
            }
            else if (columnType == typeof(double))
            {
                compareResult = Convert.ToDouble(listviewX.SubItems[columnToSort].Text).CompareTo(Convert.ToDouble(listviewY.SubItems[columnToSort].Text));
            }
            else
            {
                compareResult = ObjectCompare.Compare(listviewX.SubItems[columnToSort].Text, listviewY.SubItems[columnToSort].Text);
            }

            // Calculate correct return value based on object comparison
            if (Order == SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return compareResult;
            }
            else if (Order == SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return (-compareResult);
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }
    }
}
