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
      string description = "A Portland-based cart cafe and seller of baked goods!";
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

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_Vendor()
    {
      //Arrange
      string name01 = "Joann's Coffee";
      string description01 = "A Portland-based cart cafe and seller of baked goods!";
      string name02 = "Bob's Convenience";
      string description02 = "A convenience store of locally made products and baked goods!";
      Vendor newVendor1 = new(name01, description01);
      Vendor newVendor2 = new(name02, description02);
      List<Vendor> newVendorList = new List<Vendor> {newVendor1, newVendor2};
      //Act
      List<Vendor> result = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(newVendorList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Joann's Coffee";
      string description01 = "A Portland-based cart cafe and seller of baked goods!";
      string name02 = "Bob's Convenience";
      string description02 = "A convenience store of locally made products and baked goods!";
      Vendor newVendor1 = new(name01, description01);
      Vendor newVendor2 = new(name02, description02);
      //Act
      Vendor result = Vendor.Find(2);
      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
     //Arrange
      string title01 = "Colac Order";
      string description01 = "Joann orders 9 Colac loaves every other day. This is a reoccuring order.";
      int price01 = 30;
      string date01 = "05/14/2021";
      Order newOrder = new(title01, description01, price01, date01);
      List<Order> newOrderList = new List<Order> { newOrder };
      string name = "Joann's Coffee";
      string description = "A Portland-based cart cafe and seller of baked goods!";
      Vendor newVendor = new(name, description);
      newVendor.AddOrder(newOrder);
      //Act
      List<Order> result = newVendor.Orders;
      //Assert 
      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}