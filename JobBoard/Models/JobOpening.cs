using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public ContactInfo ContactInfo { get; set; }
    private static List<JobOpening> _jobOpenings = new List<JobOpening> {};

    public JobOpening(string title, string description, ContactInfo contactInfo)
    {
        Title = title;
        Description = description;
        ContactInfo = contactInfo;
        _jobOpenings.Add(this);
    }

    public static List<JobOpening> GetAll()
    {
      return _jobOpenings;
    }
    
    public static ContactInfo joe = new ContactInfo("Joe Dirt", "joe@dirtydude.com", "555-555-5551");
    public static ContactInfo michael = new ContactInfo("Michael Jackdaughter", "mj@heehee.net", "555-555-5552");
    public static ContactInfo stayvun = new ContactInfo("Stayvun McDaniel", "stayvun@fortune.org", "555-555-5553");
    public static ContactInfo jeff = new ContactInfo("Jeff Bezos", "smaug@amazon.com", "555-555-5554");
    public static JobOpening cleaner = new JobOpening("Cleaner", "Clean my house.", joe);
    public static JobOpening coder = new JobOpening("Coder", "Code a database.", michael);
    public static JobOpening burgerFlipper = new JobOpening("Burger Flipper", "Flip burgers at McDonalds.", stayvun);
    public static JobOpening CEO = new JobOpening("CEO", "Be the CEO of Amazon.", jeff);

    public static void ClearAll()
    {
      _jobOpenings.Clear();
    }
  }

  public class ContactInfo
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public ContactInfo(string name, string email, string phoneNumber)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
  }
}