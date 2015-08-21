using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsData
{
    public class Product
    {
        private string productCode;

        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private decimal yearsWarranty;

        public decimal YearsWarranty
        {
            get { return yearsWarranty; }
            set { yearsWarranty = value; }
        }

        private DateTime releaseDate;

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

    } //END CLASS
}
