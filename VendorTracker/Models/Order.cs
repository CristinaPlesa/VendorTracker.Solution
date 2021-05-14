using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    // will include:
    // Title, Description, Price, Date, Id

    public Order(string title)
    {

    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}