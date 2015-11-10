namespace ConsumeWebServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BookVolume
    {
        public string kind { get; set; }

        public int totalItems { get; set; }

        public Book[] items { get; set; }
    }
}
