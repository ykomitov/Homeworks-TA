namespace HTMLRenderer
{
    using System;
    using System.Text;

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
                    output.Append("<td>");
                    if (this.cells[row, col].Name != null)
                    {
                        output.Append(String.Format("<{0}>{1}</{0}>", this.cells[row, col].Name, this.cells[row, col].TextContent));
                    }
                    else
                    {
                        output.Append(String.Format("{0}", this.cells[row, col].TextContent));
                    }
                    output.Append("</td>");
                }
                output.Append("</tr>");
            }
            output.Append(String.Format("</{0}>", this.Name));
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            this.Render(output);
            return output.ToString().TrimEnd();
        }
    }
}
