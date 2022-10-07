// using MySql.Data.MySqlClient;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
// using ToDoList.Models;
// using System;

// namespace ToDoList.Tests
// {

//   [TestClass]
//   public class ItemTests : IDisposable
//   {

//     public void Dispose()
//     {
//       Item.ClearAll();
//     }
//     public void ItemTest()
//     {
//       DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=to_do_list_test;";
//     }
//     [TestMethod]
//     public void Find_ReturnsCorrectItemFromDatabase_Item()
//     {
//       //Arrange
//       Item newItem = new Item("Mow the lawn");
//       newItem.Save();
//       Item newItem2 = new Item("Wash dishes");
//       newItem2.Save();

//       //Act
//       Item foundItem = Item.Find(newItem.Id);
//       //Assert
//       Assert.AreEqual(newItem, foundItem);
//     }
//   }
// }