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

    [TestMethod]
    public void GetDate_ReturnsOrderDate_String()
    {
      //Arrange
      string title = "Colac Order";
      string description = "Joann orders 9 Colac loaves every other day. This is a reoccuring order.";
      int price = 30;
      string date = "05/14/2021";
      Order newOrder = new(title, description, price, date);
      //Act
      string result = newOrder.Date;
      //Assert
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      //Arrange
      List<Order> newList = new List<Order> { };
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrdersList_OrderList()
    {
      //Arrange
      string title01 = "Colac Order";
      string description01 = "Joann orders 9 Colac loaves every other day. This is a reoccuring order.";
      int price01 = 30;
      string date01 = "05/14/2021";
      string title02 = "Galuste cu Prune Order";
      string description02 = "Joann orders 15 Galuste pastries every other day. This is a reoccuring order.";
      int price02 = 25;
      string date02 = "05/14/2021";
      Order newOrder1 = new(title01, description01, price01, date01);
      Order newOrder2 = new(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Colac Order";
      string description = "Joann orders 9 Colac loaves every other day. This is a reoccuring order.";
      int price = 30;
      string date = "05/14/2021";
      Order newOrder = new(title, description, price, date);
      //Act
      int result = newOrder.Id;
      //Assert
      Assert.AreEqual(1, result);
    }
  }
}