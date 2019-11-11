using System;
namespace ForWaiters.Models
{
    public class Dish
    {
        
        public int id;
        private int priceForOne, priceForFew; // if 4,30zl -> 430 / 10
        private string name;
        private int quantity;

        public Dish()
        {
        }

        public Dish(int id, int quantity)
        {
            switch (id)
            {
                case 1:
                    this.id = 1;
                    this.name = "Pierogi ruskie";
                    this.quantity = quantity;
                    this.priceForOne = 1400;
                    this.priceForFew = this.priceForOne * quantity;
                    break;

                case 2:
                    this.id = 2;
                    this.name = "Zupa pomidorowa";
                    this.quantity = quantity;
                    this.priceForOne = 700;
                    this.priceForFew = this.priceForOne * quantity;
                    break;

                case 3:
                    this.id = 3;
                    this.name = "Zapiekanka z pieczarkami";
                    this.quantity = quantity;
                    this.priceForOne = 600;
                    this.priceForFew = this.priceForOne * quantity;
                    break;

                case 4:
                    this.id = 4;
                    this.name = "Lody czekoladowe";
                    this.quantity = quantity;
                    this.priceForOne = 900;
                    this.priceForFew = this.priceForOne * quantity;
                    break;

                case 5:
                    this.id = 5;
                    this.name = "Szarlotka";
                    this.quantity = quantity;
                    this.priceForOne = 1200;
                    this.priceForFew = this.priceForOne * quantity;
                    break;

                case 6:
                    this.id = 6;
                    this.name = "Sok pomarańczowy";
                    this.quantity = quantity;
                    this.priceForOne = 500;
                    this.priceForFew = this.priceForOne * quantity;
                    break;

            }
        }

        public void changeQuantity(int newQuantity)
        {
            this.quantity = newQuantity;
            this.priceForFew = this.priceForOne * this.quantity;
        }
    }
}
