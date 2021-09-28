using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public int Description { get; set; }
    public int ContactInfo { get; set; }
    private static List<JobOpening> _jobOpenings = new List<JobOpening> {};

    public JobOpening(string title, string description, ContactInfo contactInfo)
    {
        Title = title;
        Description = description;
        ContactInfo = contactInfo;
        _jobOpenings.Add(this);
    }

    // public static Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
    // public static Car yugo = new Car("1980 Yugo Koral", 700, 56000);
    // public static Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
    // public static Car amc = new Car("1976 AMC Pacer", 400, 198000);

    public static List<JobOpening> GetAll()
    {
      return _jobOpenings;
    }
  }

  public class ContactInfo
  {
    public string Name { get; set; }
    public int Email { get; set; }
    public int PhoneNumber { get; set; }
    private static List<JobOpening> _jobOpenings = new List<JobOpening> {};

    public ContactInfo(string name, string email, string phoneNumber)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
  }
}