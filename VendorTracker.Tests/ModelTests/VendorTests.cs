using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      //Arrange
      string name = "name";
      string description = "description";
      Vendor newVendor = new(name, description);
      //Act
      string result = newVendor.Name;
      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsVendorDescription_String()
    {
      //Arrange
      string name = "Joann's Coffee";
      string description = "A Porland-based cart cafe and seller of baked goods!";
      Vendor newVendor = new(name, description);
      //Act
      string result = newVendor.Description;
      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "name";
      string description = "description";
      Vendor newVendor = new(name, description);
      //Act
      int result = newVendor.Id;
      //Assert
      Assert.AreEqual(1, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsAllVendorObjects_Vendor()
    // {
    //   //Arrange
    //   string name01 = ""
    // }
  }
}