using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get ; set ; }
    public string Description { get ; set ; }
    public int Id { get ; }
    public List<Vendor> Vendors { get ; set ; }

    public Vendor()
    {

    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}