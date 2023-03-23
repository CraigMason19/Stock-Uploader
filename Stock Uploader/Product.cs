using System;

namespace WindowsFormsApplication1
{
    public class Product : IComparable<Product>
    {
        #region Data

        // Eventually I decided this was overkill as I was just matching ny product codes on sage and
        // online and made a simpler stock report design. 
        //public string Supplier { get; set; } = "";
        public string Code { get; set; } = "";
        public int Stock { get; set; } = 0;

        #endregion

        #region constructors

        public Product()
        {
            
        }

        public Product(string code, int stockLevel)
        {
            Code = code;
            Stock = stockLevel;
        }

        public Product(string code, string stockLevel)
        {
            Code = code; // Fine as a string, codes are alphanumeric.

            // The Stock report from sage will bring stock levels in as a string.
            // Sometimes with decimal places. 
            if (stockLevel == "")
            {
                Stock = 0;
            }
            else
            {
                if (stockLevel.Contains("."))
                {
                    Stock = (int)decimal.Parse(stockLevel);
                }
                else
                {
                    Stock = Int32.Parse(stockLevel);
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return Code + "," + Stock.ToString();
        }

        public int CompareTo(Product p)
        {
            return this.Code.CompareTo(p.Code);
        }

        #endregion
    }
}
