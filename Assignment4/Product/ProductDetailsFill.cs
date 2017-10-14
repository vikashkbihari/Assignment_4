using System;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    public class ProductDetailsFill : IProduct, IComparer<ProductInfo>
    {
        public List<ProductGroup> ProductGroupFill()
        {
           ProductGroup objectProductGroup1 = new ProductGroup()
           {
               ID = 1,
               Name = "Dairy"
           };

           ProductGroup objectProductGroup2 = new ProductGroup()
           {
               ID = 2,
               Name = "Fruits"
           };

           ProductGroup objectProductGroup3 = new ProductGroup()
           {
               ID = 3,
               Name = "Instant-Food"
           };

           ProductGroup objectProductGroup4 = new ProductGroup()
           {
               ID = 4,
               Name = "Sweet"
           };

           List<ProductGroup> productGroup = new List<ProductGroup>(4);

           productGroup.Add(objectProductGroup1);
           productGroup.Add(objectProductGroup2);
           productGroup.Add(objectProductGroup3);
           productGroup.Add(objectProductGroup4);

           return productGroup;
        }

        public List<ProductInfo> ProductFill()
        {
           ProductInfo objectProductInfo1 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 1,
               Name = "Amul Cheese",
               Description = "Amul Cheese 180g",
               rate = 115
           };

           ProductInfo objectProductInfo2 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 2,
               Name = "Mother  Cheese",
               Description = "Mother Cheese 210g",
               rate = 125
           }; 

           ProductInfo objectProductInfo3 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 3,
               Name = "Britania Cheese",
               Description = "Britania Cheese 200g",
               rate = 100
           };

           ProductInfo objectProductInfo4 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Fruits"),
               ID = 1,
               Name = "Apple",
               Description = "Apple 500 gm",
               rate = 40
           };
           
           ProductInfo objectProductInfo5 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Orange"),
               ID = 2,
               Name = "Green Orange",
               Description = "Fresh Greeen orange 500Gm",
               rate = 20
           };

           ProductInfo objectProductInfo6 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Instant-Food"),
               ID = 1,
               Name = "Maggie",
               Description = "100 gm instant maggie",
               rate = 100
           };

           ProductInfo objectProductInfo7 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Instance-Food"),
               ID = 2,
               Name = "Rameco",
               Description = "Rameco 100 gm ",
               rate = 120
           };

           ProductInfo objectProductInfo8 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Sweet"),
               ID = 1,
               Name = "rasgulla",
               Description = "200g fresh rasgulla ",
               rate = 80
           };

           ProductInfo objectProductInfo9 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Sweet"),
               ID = 2,
               Name = "Gulab Jamun",
               Description = "100 gm fresh gulab jamun",
               rate = 90
           };

           List<ProductInfo> productInfo = new List<ProductInfo>(9);

            productInfo.Add(objectProductInfo1);
            productInfo.Add(objectProductInfo2);
            productInfo.Add(objectProductInfo3);
            productInfo.Add(objectProductInfo4);
            productInfo.Add(objectProductInfo5);
            productInfo.Add(objectProductInfo6);
            productInfo.Add(objectProductInfo7);
            productInfo.Add(objectProductInfo8);
            productInfo.Add(objectProductInfo9);

            return productInfo;
        }

        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public IEnumerable<ProductInfo> ProductSort(List<ProductInfo> productInfo)
        {
            ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();
            productInfo.Sort(objectProductDetailsFill);
            return productInfo;
        }

        public List<ProductInfo> ProductDelete1(List<ProductInfo> productInfo, int num)
        {    
            productInfo.RemoveAt(num);
            return productInfo;
        }

        public List<ProductInfo> ProductDelete2(List<ProductInfo> productInfo)
        {
            productInfo.RemoveAll(item => item.rate>100);
            return productInfo;
        }

        public List<ProductInfo> ProductDelete3(List<ProductInfo> productInfo, int start, int end)
        {
            productInfo.RemoveRange(start,end);
            return productInfo;
        }



        public List<ProductInfo> ProductDelete4(List<ProductInfo> productInfo, string productName)
        {
            List<ProductInfo> productInfoSample = null;

            foreach(ProductInfo item in productInfo)
            {
                if(item.Name.Contains(productName))
                {
                    FindIndex objectFindIndex = new FindIndex();
                    int index = objectFindIndex.Find(productName);
                    productInfo.RemoveAt(index);
                    break;
                }
                else
                { 
                    productInfo = productInfoSample;
                    break;
                }    
            }

            return productInfo;
            
        }
    }
}