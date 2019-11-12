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
            

            if (indexOfTable == 0)
            {
                lblDishesForFirstTable.Items.Clear();
                for (int i = 0; i < dishes.Count; i++)
                {
                    
                    lblDishesForFirstTable.Items.Add(dishes[i].getQuantity().ToString() + "x" + dishes[i].getName() + " " + (dishes[i].getPrice() / 100.0f).ToString() + "zł" + "*" + dishes[i].getQuantity().ToString() + "=" + (dishes[i].getPriceForFew() / 100.0f).ToString() + "zł");
                    firstBill.Text = (tablesList[indexOfTable].getBil() / 100.0f).ToString() + "zł";
                }
            }else if(indexOfTable == 1)
            {
                lblDishesForSecondTable.Items.Clear();
                for (int i = 0; i < dishes.Count; i++)
                {
                    lblDishesForSecondTable.Items.Add(dishes[i].getQuantity().ToString() + "x" + dishes[i].getName() + " " + (dishes[i].getPrice() / 100.0f).ToString() + "zł" + "*" + dishes[i].getQuantity().ToString() + "=" + (dishes[i].getPriceForFew() / 100.0f).ToString() + "zł");
                    secondBill.Text = (tablesList[indexOfTable].getBil() / 100.0f).ToString() + "zł";
                }
            }
            else if (indexOfTable == 2)
            {
                lblDishesForThirdTable.Items.Clear();
                for (int i = 0; i < dishes.Count; i++)
                {
                    lblDishesForThirdTable.Items.Add(dishes[i].getQuantity().ToString() + "x" + dishes[i].getName() + " " + (dishes[i].getPrice() / 100.0f).ToString() + "zł" + "*" + dishes[i].getQuantity().ToString() + "=" + (dishes[i].getPriceForFew() / 100.0f).ToString() + "zł");
                    thirdBill.Text = (tablesList[indexOfTable].getBil() / 100.0f).ToString() + "zł";
                }
            }
            else if (indexOfTable == 3)
            {
                lblDishesForFourthTable.Items.Clear();
                for (int i = 0; i < dishes.Count; i++)
                {
                    lblDishesForFourthTable.Items.Add(dishes[i].getQuantity().ToString() + "x" + dishes[i].getName() + " " + (dishes[i].getPrice() / 100.0f).ToString() + "zł" + "*" + dishes[i].getQuantity().ToString() + "=" + (dishes[i].getPriceForFew() / 100.0f).ToString() + "zł");
                    fourthBill.Text = (tablesList[indexOfTable].getBil() / 100.0f).ToString() + "zł";
                }
            }
            else if (indexOfTable == 4)
            {
                lblDishesForFifthTable.Items.Clear();
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
                    tablesList[0].removeDishAt(i);
                   
                }
            }
            foreach (ListItem listItem in itemsToRemove)
            {
                lblDishesForFirstTable.Items.Remove(listItem);
            }

            loadDisheshInView(0);

        }

        public void deleteSelectedFromSecondTable(object sender, EventArgs args)
        {
            List<ListItem> itemsToRemove = new List<ListItem>();

            for (int i = 0; i < lblDishesForSecondTable.Items.Count; i++)
            {
                if (lblDishesForSecondTable.Items[i].Selected)
                {
                    itemsToRemove.Add(lblDishesForSecondTable.Items[i]);
                    tablesList[1].removeDishAt(i);

                }
            }
            foreach (ListItem listItem in itemsToRemove)
            {
                lblDishesForSecondTable.Items.Remove(listItem);
            }

            loadDisheshInView(1);
        }

        public void deleteSelectedFromThirdTable(object sender, EventArgs args)
        {
            List<ListItem> itemsToRemove = new List<ListItem>();

            for (int i = 0; i < lblDishesForThirdTable.Items.Count; i++)
            {
                if (lblDishesForThirdTable.Items[i].Selected)
                {
                    itemsToRemove.Add(lblDishesForThirdTable.Items[i]);
                    tablesList[2].removeDishAt(i);

                }
            }
            foreach (ListItem listItem in itemsToRemove)
            {
                lblDishesForThirdTable.Items.Remove(listItem);
            }
            loadDisheshInView(2);
        }

        public void deleteSelectedFromFourthTable(object sender, EventArgs args)
        {
            List<ListItem> itemsToRemove = new List<ListItem>();

            for (int i = 0; i < lblDishesForFourthTable.Items.Count; i++)
            {
                if (lblDishesForFourthTable.Items[i].Selected)
                {
                    itemsToRemove.Add(lblDishesForFourthTable.Items[i]);
                    tablesList[3].removeDishAt(i);
                    

                }
            }
            foreach (ListItem listItem in itemsToRemove)
            {
                lblDishesForFourthTable.Items.Remove(listItem);
            }
            loadDisheshInView(3);
        }

        public void deleteSelectedFromFifthTable(object sender, EventArgs args)
        {
            List<ListItem> itemsToRemove = new List<ListItem>();

            for (int i = 0; i < lblDishesForFifthTable.Items.Count; i++)
            {
                if (lblDishesForFifthTable.Items[i].Selected)
                {
                    itemsToRemove.Add(lblDishesForFifthTable.Items[i]);
                    tablesList[4].removeDishAt(i);

                }
            }
            foreach (ListItem listItem in itemsToRemove)
            {
                lblDishesForFifthTable.Items.Remove(listItem);
            }
            loadDisheshInView(4);
        }

        public void changeQuantitySelectedInFirstTable(object sender, EventArgs args)
        {

        }
    }
}
