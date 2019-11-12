using System;
using System.Collections.Generic;

namespace ForWaiters.Models
{
    public class Table
    {
        public static int id = id++;
        private List<Dish> dishes = new List<Dish>();
        private float billValue = 0.0f;

        public Table()
        {
        }

        public void addDishToTable(int quantity, int id)
        {
            Dish dish = new Dish(id, quantity);
            this.dishes.Clear();
            this.dishes.Add(dish);
            this.billValue += dish.getPriceForFew();
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

        public List<Dish> getDishes()
        {
            return this.dishes;
        }

        public float getBil()
        {
            return this.billValue;
        }

    }
}
