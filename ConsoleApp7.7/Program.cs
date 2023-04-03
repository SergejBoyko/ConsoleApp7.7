using System; // Подключенное пространство имен
using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

abstract class Delivery
{
    public string Address;
    public int AllOrders;
    public decimal WeightOrders;
    public string Material;
    public decimal Volume;
}
class HomeDelivery : Delivery
{
    public void GetTypeHomeDelivery()
    {
        if (AllOrders > 5 | WeightOrders > 15 | Volume > 12)
        {
            Console.WriteLine("Заказ будет доставлен курьерской службой");
        }
        else
        {
            Console.WriteLine("Заказ будет доставлен курьером");
        }
    }
}
class PickPointDelivery : Delivery
{
    public void GetTypePickPointDelivery()
    {
        if (AllOrders > 5 | WeightOrders > 15 | Volume > 12)
        {
            Console.WriteLine("Заказ будет доставлен в пункт выдачи");
        }
        else
        {
            Console.WriteLine("Заказ будет размещён в постамате");
        }
    }
}
class ShopDelivery : Delivery
{
    public void SendInShopDelivery()
    {
        Console.WriteLine("Заказ будет доставлен в Магазин по адресу {0}", Address);
    }
}
class Order<TDelivery, TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;
    public int Number;
    public string Description;
    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }
}
class Weight<TDelivery, TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;
    public int Number;
    public string Description;
    public void DisplayWeight()
    {
        Console.WriteLine(Delivery.WeightOrders);
    }
}
class AllOrders<TDelivery, TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;
    public int Number;
    public string Description;
    public void DisplayAllOrders()
    {
        Console.WriteLine(Delivery.AllOrders);
    }
}
class GetTypeMaterial<TDelivery, TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;
    public int Number;
    public string Description;
    public void DisplayTypeMaterial()
    {
        Console.WriteLine(Delivery.Material);
    }
}
class Volume<TDelivery, TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;
    public int Number;
    public string Description;
    public void DisplayVolume()
    {
        Console.WriteLine(Delivery.Volume);
    }
}