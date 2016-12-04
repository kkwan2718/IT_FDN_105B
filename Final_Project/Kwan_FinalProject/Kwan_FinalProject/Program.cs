// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
struct ItemData
{
    public int itemIDNo; // item number
    public string sDescription; // item description
    public double dblPricePerItem; // price per item
    public int iQuantityOnHand; // quantity
    public double dblOurCostPerItem; // cost per item
    public double dblValueOfItem; // value of item = price * qty
}


class MyInventory
{
    public static void Main()
    {
        // use an interger to keep track of the count of items in your inventory					
        int itemCount = 0;
        int arrayMax = 100;

        // create an array of your ItemData struct of size 10
        ItemData[] items = new ItemData[arrayMax]; 

        // use a never ending loop that shows the user what options they can select 
        while(true)
        {
           
            Console.WriteLine("\n1. Add an item");
            Console.WriteLine("2. Change an item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. List all items in the database");
            Console.WriteLine("5. Quit \n");
            Console.Write("Select an option from the list above: ");

            string strx = Console.ReadLine();   // read user's input	

            int optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

            Console.WriteLine(); // provide an extra blank line on screen

            switch (optx)
            {
                // Add an item to the database
                case 1:
                    {

                        Console.Write("Enter the item ID No. (3 digits): ");       
                        int itemID = int.Parse(Console.ReadLine());

                        Console.Write("Item Description:                 ");
                        string des = Console.ReadLine();

                        Console.Write("Price per item:                $  ");
                        double pricePerItem = double.Parse(Console.ReadLine());

                        Console.Write("Quantity on hand:                 ");
                        int qty = int.Parse(Console.ReadLine());

                        Console.Write("Cost per item:                 $  ");
                        double costPerItem = double.Parse(Console.ReadLine());

                        // Stores data in the struct
                        items[itemCount].itemIDNo = itemID;
                        items[itemCount].sDescription = des;
                        items[itemCount].dblPricePerItem = pricePerItem;
                        items[itemCount].iQuantityOnHand = qty;
                        items[itemCount].dblOurCostPerItem = costPerItem;
                        items[itemCount].dblValueOfItem = pricePerItem * qty;

                        itemCount++; // Increments the number of items in the database
                           
                        break;
                    }

                // Change an item in the database
                case 2:
                    {
                        if (itemCount == 0) // if the database is empty
                        {
                            Console.WriteLine("!! There are no items in the database.");
                        }

                        else
                        {
                            Console.Write("Please enter an item ID No: ");
                            string strchgid = Console.ReadLine();
                            int chgID = int.Parse(strchgid);
                            bool fFound = false;

                            for (int x = 0; x < itemCount; x++)
                            {
                                if (items[x].itemIDNo == chgID)
                                {
                                    fFound = true;

                                    // Collects new information
                                    Console.Write("Item Description:           ");
                                    string des_new = Console.ReadLine();

                                    Console.Write("Price per item:          $  ");
                                    double pricePerItem_new = double.Parse(Console.ReadLine());

                                    Console.Write("Quantity on hand:           ");
                                    int qty_new = int.Parse(Console.ReadLine());

                                    Console.Write("Cost per item:           $  ");
                                    double costPerItem_new = double.Parse(Console.ReadLine());

                                    items[x].sDescription = des_new;
                                    items[x].dblPricePerItem = pricePerItem_new;
                                    items[x].iQuantityOnHand = qty_new;
                                    items[x].dblOurCostPerItem = costPerItem_new;
                                    items[x].dblValueOfItem = pricePerItem_new * qty_new;
                                }
                            }

                            if (!fFound) // and if not found
                            {
                                Console.WriteLine("!! Item {0} not found", chgID);
                            }
                        }
                        
                        break;
                        
                    }

                // Delete an item from the database
                case 3:
                    {
                        if (itemCount == 0)
                        {
                            Console.WriteLine("!! There are no items in the database.\n");
                        }

                        else
                        {
                            Console.Write("Please enter an item ID to delete: ");
                            string strnewid = Console.ReadLine();
                            int delete_id = int.Parse(strnewid);
                            bool fDeleted = false;

                            for (int x = 0; x < itemCount; x++)
                            {
                                if (items[x].itemIDNo == delete_id)
                                {
                                    fDeleted = true;

                                    for (int i = x; i < itemCount; i++)
                                    {
                                        items[i] = items[i + 1]; // Replaces deleted item with next item on list
                                    }

                                    itemCount--; // decrements the total item count
                                   							
                                }
                            }

                            if (fDeleted) // hint the user that you deleted the requested item
                            {
                                Console.WriteLine("\n!! Item deleted");
                            }
                            else // if did not find it, hint the user that you did not find it in your list
                            {
                                Console.WriteLine("\n!! Item {0} not found", delete_id);
                            }
                        }
                        
                        break;
                    }

                // List all the items in the database
                case 4:
                    {

                       if (itemCount == 0)
                        {
                            Console.WriteLine("!! There are no items in the database.");
                        }

                        else
                        {
                            Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                            Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");

                            for (int x = 0; x < itemCount; x++)
                            {
                                Console.WriteLine("{0,5}  {1,6}  {2,-20}  {3,-5}  {4,-3}  {5,-4}  {6,-5}", x + 1, items[x].itemIDNo, items[x].sDescription, items[x].dblPricePerItem, items[x].iQuantityOnHand, items[x].dblOurCostPerItem, items[x].dblValueOfItem);
                            }
                        }
                                            
                       break;
                    }

                // Quit the program
                case 5:
                    {
                        Console.Write("Are you sure that you want to quit(y/n)? ");
                        string strresp = Console.ReadLine();

                        if (strresp == "y")
                         {
                            return; // Exits the while loop
                         }

                        break;
                    }

                default:
                    {
                        Console.WriteLine("!! Invalid Option, try again");
                        break;
                    }
            }

        }
    }
}