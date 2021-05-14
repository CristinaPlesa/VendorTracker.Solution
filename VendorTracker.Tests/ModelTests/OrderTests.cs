using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new("title", "description", 0, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      //Arrange
      string title = "Colac Order";
      string description = "Joann orders 9 Colac loaves every other day. This is a reoccuring order.";
      int price = 30;
      string date = "05/14/2021";
      Order newOrder = new(title, description, price, date);
      //Act
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      //Arrange
      string title = "Colac Order";
      string description = "Joann orders 9 Colac loaves every other day. This is a reoccuring order.";
      int price = 30;
      string date = "05/14/2021";
      Order newOrder = new(title, description, price, date);
      //Act
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Int()
    {
      //Arrange
      string title = "Colac Order";
      string description = "Joann orders 9 Colac loaves every other day. This is a reoccuring order.";
      int price = 30;
      string date = "05/14/2021";
      Order newOrder = new(title, description, price, date);
      //Act
      int result = newOrder.Price;
      //Assert
      Assert.AreEqual(price, result);
    }
  }
}