using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBuilder
{
    internal class Program
    {

        class Meal
        {
            private string _mealType;
            private Dictionary<string, string> _option = new Dictionary<string, string>();
            public Meal(string mealType)
            {
                this._mealType = mealType;
            }

            public string this[string key]
            {
                get { return _option[key]; }
                set { _option[key] = value; }
            }

            public void Show()
            {
                Console.WriteLine("\n---------------");
                Console.WriteLine($"MealType:{_mealType}");
                Console.WriteLine($"burger {_option["burger"]}");
                Console.WriteLine($"Drink {_option["drink"]}");
                Console.WriteLine($"Dessert {_option["dessert"]}");
                Console.WriteLine($"Toy {_option["toy"]}");
            }
        }
        abstract class MealBuilder
        {
            protected Meal meal;

            public Meal Meal { get { return meal; } }

            public abstract void Burger();
            public abstract void Drink();
            public abstract void Dessert();
            public abstract void Toy();

        }

        class MealPack1 : MealBuilder
        {
            public MealPack1()
            {
                meal = new Meal("Meal Pack1");

            }
            public  override void Burger()
            {
                meal["burger"] = "Chicken Burger";

            }
            public override void Drink()
            {
                meal["drink"] = "Coca Cola";
            }
            public override void Dessert()
            {
                meal["dessert"] = "Choco Donut";
            }
            public override void Toy()
            {
                meal["toy"] = "Marvel Ironman";
            }



        }


        class MealPack2 : MealBuilder
        {
            public MealPack2()
            {
                meal = new Meal("Meal Pack Veg");

            }
            public override void Burger()
            {
                meal["burger"] = "Veg whooper";

            }
            public override void Drink()
            {
                meal["drink"] = "Pepsi";
            }
            public override void Dessert()
            {
                meal["dessert"] = "Choco Brownie";
            }
            public override void Toy()
            {
                meal["toy"] = "Marvel Hulk";
            }
        }

        class MealPack3 : MealBuilder
        {
            public MealPack3()
            {
                meal = new Meal("Meal Pack Ultra");

            }
            public override void Burger()
            {
                meal["burger"] = "Chicken Burger+ chicken Whooper";

            }
            public override void Drink()
            {
                meal["drink"] = "Coca Cola + Pepsi";
            }
            public override void Dessert()
            {
                meal["dessert"] = "Choco Donut+fudge";
            }
            public override void Toy()
            {
                meal["toy"] = "Marvel Deadpool";
            }
        }

         class MealPack4 : MealBuilder
            {
                public MealPack4()
                {
                    meal = new Meal("Meal Pack veg ultra");

                }
                public override void Burger()
                {
                    meal["burger"] = "Veg Burger+ veg whooper";

                }
                public override void Drink()
                {
                    meal["drink"] = "Coca Cola + Dew";
                }
                public override void Dessert()
                {
                    meal["dessert"] = "Choco fudge + Icecream";
                }
                public override void Toy()
                {
                    meal["toy"] = "Marvel Spiderman";
                }
            }

          class Shop
                {
                    public void Construct(MealBuilder mealBuilder)
                    {
                        mealBuilder.Burger();
                        mealBuilder.Drink();
                        mealBuilder.Dessert();
                        mealBuilder.Toy();
                    }

                }

     static void Main(string[] args)
        {
            MealBuilder mealBuild;
            Shop shop = new Shop();


            mealBuild = new MealPack1();
            shop.Construct(mealBuild);
            mealBuild.Meal.Show();

            mealBuild = new MealPack2();
            shop.Construct(mealBuild);
            mealBuild.Meal.Show();

            mealBuild = new MealPack3();
            shop.Construct(mealBuild);
            mealBuild.Meal.Show();

            mealBuild = new MealPack4();
            shop.Construct(mealBuild);
            mealBuild.Meal.Show();
            Console.ReadKey();
        }
    }
}
