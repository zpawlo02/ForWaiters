﻿using System;
using System.Collections.Generic;

namespace ForWaiters.Models
{
    public class Table
    {
        public static int id = id++;
        private List<Dish> dishes = new List<Dish>();
        private int billValue = 0;

        public Table()
        {
        }

        public void addDishToTable(int quantity, int id)
        {
            this.dishes.Add(new Dish(id, quantity));
        }

        //wybierajac danie z listy pobieram na jakim indeksie jest danie
        public void deleteDishFromTable(int whichDish)
        {
            this.dishes.RemoveAt(whichDish);
        }

        //whichDish to indeks dania z listy zamowien
        public void changeQuantityOfDishes(int whichDish, int newQuantity)
        {
            this.dishes[whichDish].changeQuantity(newQuantity);
        }


    }
}
