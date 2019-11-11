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
                    
                }
            }
            
        }

        private int quantityOfSlectedDish(string id)
        {
            int quantitySelected = 1;
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
            return quantitySelected;
        }
    }
}
