using Adv19;

try
{
    Basket basket = new Basket();
    basket.AddToBasket();//1
    basket.AddToBasket();//2
    basket.AddToBasket();//3
    basket.AddToBasket();//4
    basket.AddToBasket();//5
    basket.AddToBasket();//6
    basket.AddToBasket();//7
    basket.AddToBasket();//8
    basket.AddToBasket();//9
    basket.AddToBasket();//10
    //basket.AddToBasket();//Exception
    basket.RemoveFromBasket();//9
    basket.RemoveFromBasket();//8
    basket.RemoveFromBasket();//7
    basket.RemoveFromBasket();//6
    basket.RemoveFromBasket();//5
    basket.RemoveFromBasket();//4
    basket.RemoveFromBasket();//3
    basket.RemoveFromBasket();//2
    basket.RemoveFromBasket();//1
    basket.RemoveFromBasket();//0
    basket.RemoveFromBasket();//Exception
}
catch (BasketEmptyException ex)
{
    Console.WriteLine("Basket is empty.");
}
catch (BasketFullException ex)
{
    Console.WriteLine("Basket is full.");
}