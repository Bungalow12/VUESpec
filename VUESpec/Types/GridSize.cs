using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUESpec.Types
{
    [TypeConverter(typeof(GridSizeConverter))]
    public class GridSize 
    {
        private int columns = 0;
        private int rows = 0;
        private readonly int maxColumns;
        private readonly int maxRows;

        public GridSize() : this(64, 64)
        { }

        public GridSize(int maxColumns, int maxRows)
        {
            this.maxColumns = maxColumns;
            this.maxRows = maxRows;
        }

        [Browsable(true)]
        [Description("Number of columns.")]
        public int Columns
        {
            get
            {
                return this.columns;
            }

            set
            {
                columns = Math.Min(maxColumns, Math.Max(0, value));
            }
        }

        [Browsable(true)]
        [Description("Number of rows.")]
        public int Rows
        {
            get
            {
                return this.rows;
            }

            set
            {
                rows = Math.Min(maxRows, Math.Max(0, value));
            }
        }

        public override string ToString()
        {
            return $"{this.columns}, {this.rows}";
        }
    }
}
