namespace HTMLRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HTMLTable : HTMLElement, IElement, ITable
    {
        private int rows;
        private int cols;
        private IElement[,] cells;

        public HTMLTable(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.Name = "table";
            this.cells = new IElement[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                return this.cells[row, col];
            }
            set
            {
                this.cells[row, col] = value;
            }
        }

        public new void Render(StringBuilder output)
        {
            output.Append(String.Format("<{0}>", this.Name));

            for (int row = 0; row < this.cells.GetLength(0); row++)
            {
                output.Append("<tr>");
                for (int col = 0; col < this.cells.GetLength(1); col++)
                {
                    output.Append(String.Format("<td>{0})</td>>", this.cells[row, col].TextContent));
                }
                output.Append("</tr>");
            }
            output.Append(String.Format("</{0}>", this.Name));
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            this.Render(output);
            return output.ToString();
        }
    }
}
