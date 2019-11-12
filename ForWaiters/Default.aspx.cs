using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ForWaiters.Models;

namespace ForWaiters
{

    public partial class Default : System.Web.UI.Page
    {
        static Models.Table tableFirst = new Models.Table(), tableSecond = new Models.Table(), tableThird = new Models.Table(), tableFourth = new Models.Table(), tableFifth = new Models.Table();
        static List<Models.Table> tablesList = new List<Models.Table>() { tableFirst, tableSecond, tableThird, tableFourth, tableFifth };

        public void addDishesOnButtonClick(object sender, EventArgs args)
        {
            foreach (ListItem listItem in lblMultiSelectOfTables.Items)
            {
                if (listItem.Selected)
                {
                    foreach(ListItem listItem1 in lblMultiSelectOfDishes.Items)
                    {
                        if (listItem1.Selected) {

                            tablesList[int.Parse(listItem.Value)].addDishToTable(quantityOfSlectedDish(listItem1.Value), int.Parse(listItem1.Value));
                            
                           
                        }

                    }
                    loadDisheshInView(int.Parse(listItem.Value));

                }
            }
            
        }

        private int quantityOfSlectedDish(string id)
        {
            int quantitySelected = 1;
            try
            {
                if (id == "0")
                {
                    quantitySelected = int.Parse(txtBoxQuantityPierogi.Text);
                }
                else if (id == "1")
                {
                    quantitySelected = int.Parse(txtBoxQuantityZupa.Text);
                }
                else if (id == "2")
                {
                    quantitySelected = int.Parse(txtBoxQuantityZapiekanka.Text);
                }
                else if (id == "3")
                {
                    quantitySelected = int.Parse(txtBoxQuantityLody.Text);
                }
                else if (id == "4")
                {
                    quantitySelected = int.Parse(txtBoxQuantitySzarlotka.Text);
                }
                else if (id == "5")
                {
                    quantitySelected = int.Parse(txtBoxQuantitySok.Text);
                }
            }
            catch
            {

            }
            
            return quantitySelected;
        }

        public void loadDisheshInView(int indexOfTable)
        {
            List<Dish> dishes = new List<Dish>(tablesList[indexOfTable].getDishes());
            tablesList[indexOfTable].getDishes().Clear();

            if(indexOfTable == 0)
            {
                for(int i = 0; i < dishes.Count; i++)
                {
                    lblDishesForFirstTable.Items.Add(dishes[i].getQuantity().ToString() + "x" + dishes[i].getName() + " " + (dishes[i].getPrice() / 100.0f).ToString() + "zł" + "*" + dishes[i].getQuantity().ToString() + "=" + (dishes[i].getPriceForFew() / 100.0f).ToString() + "zł");
                    firstBill.Text = (tablesList[indexOfTable].getBil() / 100.0f).ToString() + "zł";
                }
            }else if(indexOfTable == 1)
            {
                for (int i = 0; i < dishes.Count; i++)
                {
                    lblDishesForSecondTable.Items.Add(dishes[i].getQuantity().ToString() + "x" + dishes[i].getName() + " " + (dishes[i].getPrice() / 100.0f).ToString() + "zł" + "*" + dishes[i].getQuantity().ToString() + "=" + (dishes[i].getPriceForFew() / 100.0f).ToString() + "zł");
                    secondBill.Text = (tablesList[indexOfTable].getBil() / 100.0f).ToString() + "zł";
                }
            }
            else if (indexOfTable == 2)
            {
                for (int i = 0; i < dishes.Count; i++)
                {
                    lblDishesForThirdTable.Items.Add(dishes[i].getQuantity().ToString() + "x" + dishes[i].getName() + " " + (dishes[i].getPrice() / 100.0f).ToString() + "zł" + "*" + dishes[i].getQuantity().ToString() + "=" + (dishes[i].getPriceForFew() / 100.0f).ToString() + "zł");
                    thirdBill.Text = (tablesList[indexOfTable].getBil() / 100.0f).ToString() + "zł";
                }
            }
            else if (indexOfTable == 3)
            {
                for (int i = 0; i < dishes.Count; i++)
                {
                    lblDishesForFourthTable.Items.Add(dishes[i].getQuantity().ToString() + "x" + dishes[i].getName() + " " + (dishes[i].getPrice() / 100.0f).ToString() + "zł" + "*" + dishes[i].getQuantity().ToString() + "=" + (dishes[i].getPriceForFew() / 100.0f).ToString() + "zł");
                    fourthBill.Text = (tablesList[indexOfTable].getBil() / 100.0f).ToString() + "zł";
                }
            }
            else if (indexOfTable == 4)
            {
                for (int i = 0; i < dishes.Count; i++)
                {
                    lblDishesForFifthTable.Items.Add(dishes[i].getQuantity().ToString() + "x" + dishes[i].getName() + " " + (dishes[i].getPrice() / 100.0f).ToString() + "zł" + "*" + dishes[i].getQuantity().ToString() + "=" + (dishes[i].getPriceForFew()/ 100.0f).ToString() + "zł");
                    fifthBill.Text = (tablesList[indexOfTable].getBil() / 100.0f).ToString() + "zł";
                }
            }

        }

        public void deleteSelectedFromFirstTable(object sender, EventArgs args)
        {
            List<ListItem> itemsToRemove = new List<ListItem>();

            for(int i = 0; i < lblDishesForFirstTable.Items.Count; i++)
            {
                if (lblDishesForFirstTable.Items[i].Selected)
                {
                    itemsToRemove.Add(lblDishesForFirstTable.Items[i]);
                //    tablesList[0].getDishes().RemoveAt(i-1);
                   //TODO FIX REMOVING FROM TABLE 
                }
            }
            foreach (ListItem listItem in itemsToRemove)
            {
                lblDishesForFirstTable.Items.Remove(listItem);
            }

        }

    }
}
