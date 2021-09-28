using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.Tests
{
  [TestClass]
  public class JobOpeningTests : IDisposable
  {

    public void Dispose()
    {
      JobOpening.ClearAll();
    }

    [TestMethod]
    public void JobOpeningConstructor_CreatesInstanceOfJobOpening_JobOpening()
    {
      ContactInfo newContact = new ContactInfo("test", "test", "test");
      JobOpening newJob = new JobOpening("test", "test", newContact);
      Assert.AreEqual(typeof(JobOpening), newJob.GetType());
      Assert.AreEqual(typeof(ContactInfo), newContact.GetType());
    }

    [TestMethod]
    public void GetMethods_Returnsinfo_String()
    {
      string title = "1";
      string description = "2";
      string name = "3";
      string email = "4";
      string phoneNumber = "5";
      
      ContactInfo testContact = new ContactInfo(name, email, phoneNumber);
      JobOpening newJob = new JobOpening(title, description, testContact);
      string resultTitle = newJob.Title;
      string resultDescription = newJob.Description;
      string resultName = newJob.ContactInfo.Name;
      string resultEmail = newJob.ContactInfo.Email;
      string resultPhoneNumber = newJob.ContactInfo.PhoneNumber;

      Assert.AreEqual(title, resultTitle);
      Assert.AreEqual(description, resultDescription);
      Assert.AreEqual(name, resultName);
      Assert.AreEqual(email, resultEmail);
      Assert.AreEqual(phoneNumber, resultPhoneNumber);
    }

    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);

    //   //Act
    //   string updatedDescription = "Do the dishes";
    //   newItem.Description = updatedDescription;
    //   string result = newItem.Description;

    //   //Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_ItemList()
    // {
    //   // Arrange
    //   List<Item> newList = new List<Item> { };

    //   // Act
    //   List<Item> result = Item.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);
    //   List<Item> newList = new List<Item> { newItem1, newItem2 };

    //   //Act
    //   List<Item> result = Item.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
}