using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Display NewDisplay = new Display();
                int  index, start, end;
                string choice, choice1;
                string str=null;
                string str1 = null;
                string product;

                do
                {
                       
                        Console.WriteLine("Welcome----Select from the Below:");
                        Console.WriteLine("1. Display the Contents");
                        Console.WriteLine("2. Sort the Product in alphabetrical order");
                        Console.WriteLine("3. Know more about product (please enter product name)");
                        Console.WriteLine("4. Delete the product:");
                        choice = (Console.ReadLine());

                        switch(choice)
                        {
                                case "1": Console.WriteLine("-------------------------------------------------------");
                                        NewDisplay.DisplayAll();
                                        Console.WriteLine("-------------------------------------------------------");
                                        break;

                                case "2": Console.WriteLine("-------------------------------------------------------");
                                        NewDisplay.displaySortedProducts();
                                        Console.WriteLine("-------------------------------------------------------"); 
                                        break;

                                case "3": Console.WriteLine("-------------------------------------------------------");        
                                        Console.WriteLine("Please enter the Product Name or a part of the Product name to search with");
                                        str = Console.ReadLine();
                                        NewDisplay.DisplayFound(str);
                                        Console.WriteLine("-------------------------------------------------------");
                                        break;

                                case "4": do
                                        {
                                                Console.WriteLine("-------------------------------------------------------");
                                                Console.WriteLine("Please select from the following:");
                                                Console.WriteLine("1. Delete at a Particular index");
                                                Console.WriteLine("2. Delete items meeting certain conditions");
                                                Console.WriteLine("3. Delete a Range of Products");
                                                Console.WriteLine("4. Delete by a Product Name");
                                                Console.WriteLine("-------------------------------------------------------");
                                                choice1 = (Console.ReadLine());
                                                switch(choice1)
                                                {
                                                case "1": Console.WriteLine("Please enter the index:");
                                                          index = int.Parse(Console.ReadLine());
                                                          NewDisplay.DisplayAfterDeletion1(index);
                                                          break;
                                                case "2": Console.WriteLine("Deleting the Products having a rate greater than 100");
                                                          NewDisplay.DisplayAfterDeletion2();
                                                          break;
                                                case "3": Console.WriteLine("Please enter the Start and the End index");
                                                          start = int.Parse(Console.ReadLine());
                                                          end = int.Parse(Console.ReadLine());
                                                          NewDisplay.DisplayAfterDeletion3(start,end);
                                                          break;
                                                case "4": Console.WriteLine("Please enter a product name"); 
                                                          product = Console.ReadLine();
                                                          NewDisplay.DisplayAfterDeletion4(product);
                                                          break;

                                                default: Console.WriteLine("Sorry! Wrong Input");
                                                         break;        
                                                }
                                                Console.WriteLine("Would you like to Continue with the delete only(Yes/No) ?");
                                                str1 = Console.ReadLine();
                                        }while(str1.ToUpper() == "YES");
                                        break;

                                default: Console.WriteLine("Sorry! Wrong Input");
                                        break;        
                        }
                        Console.WriteLine("Would you like to Continue?(Yes/No)");
                        int flag=0;
                        str = Console.ReadLine();
                       do
                       {      
                              if(str != "yes" || str !="YES" || str != "no" || str !="NO")
                              {
                               Console.WriteLine("Sorry you have enter wrong options ");
                               Console.WriteLine("Please enter options yes for continue or no  to exit ");
                                str1 = Console.ReadLine();
                              }
                              else{
                               
                               flag=0;
                              }
                              Console.WriteLine(flag);
                       } 
                       while (flag!=0);


                }while(str1.ToUpper() == "YES");     

                }
                catch(Exception){
                    Console.WriteLine("Sorry something is wrong");
            }
        }
    }
}
