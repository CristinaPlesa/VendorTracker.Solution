using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get ; set ; }
    public string Description { get ; set ; }
    public int Price { get ; }
    public int Date { get ; }
    public int Id { get ; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, int price, int date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}