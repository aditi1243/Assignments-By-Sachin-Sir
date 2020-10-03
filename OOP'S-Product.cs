using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S_Product
{
    class TestProduct
    {
        static void Main(string[] args)
        { Product p = new Product("laptop", 45000.00, 'E');
            p.Getproductdetails();
            Console.ReadKey;

        }
        public class Product
        {
            private string productCode;
            private string productname;
            private double productPrice;
            private char categoryCode;

            // 'categoryCode'=('E-electronics','A-appareals','T-toys')

            private static int prodCounter = 100;

            public string ProductCode//properties should be public 
            {
                get { return productCode; }
                set { productCode = value; }
            }

            public string ProductName
            {
                get { return productname; }
                set { productname = value; }
            }

            public double ProductPrice
            {
                get { return productPrice; }
                set { productPrice = value; }
            }

            public char CategoryCode
            {
                get { return categoryCode; }
                set { categoryCode = value; }

            }

            private string generateProductCode(char c)
            {
                
                int x = productCounter + 1;
                string prodCount = x.ToString();
                productCode = categoryCode + prodCount;
                return productCode;
            }

            public Product(string productname,double productPrice,char catrgoryCode)
            {
                this.productname = productname;
                this.ProductPrice = productPrice;
                //  this.categoryCode = categoryCode;
                this.ProductCode = generateProductCode(code);
                this.categoryCode = code;
            }
            public Product(string productname,double productprice)
            {

                this.ProductName = productname;
                this.productPrice = productPrice;
                this.ProductCode = generateProductCode(categoryCode);
                this.categoryCode = 'E';
            }
            public void getProductDretails()
            {
                Console.WriteLine("product code{0}", productCode);
                Console.WriteLine("product name{0}", productname);
                Console.WriteLine("product price{0}", productPrice);
                Console.WriteLine("category {0}", CategoryCode);
            }
    }
}
