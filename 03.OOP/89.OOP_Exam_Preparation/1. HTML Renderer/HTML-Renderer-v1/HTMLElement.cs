namespace HTMLRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HTMLElement : IElement
    {
        private string name;
        private string textContent;
        private List<IElement> childElements;

        public HTMLElement()
        {
        }

        public HTMLElement(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }

        public HTMLElement(string name, string content)
        {
            this.Name = name;
            this.TextContent = content;
            this.childElements = new List<IElement>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                this.name = value;
            }
        }

        public string TextContent
        {
            get
            {
                return this.textContent;
            }
            set
            {
                this.textContent = value;
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public void Render(StringBuilder output)
        {
            output.Append(String.Format("<{0}>", this.Name));
            output.Append(String.Format("{0}", this.TextContent));

            if (childElements.Count > 0)
            {
                foreach (var element in childElements)
                {
                    output.Append(element);
                }
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
