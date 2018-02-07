using System.Collections.Generic;
using System;

namespace Resumes.Models
{
  public class Resume
  {
    private string _businessName;
    private string _jobTitle;
    private string _jobDescription;
    private string _duration;
    private int _contactNumber;
    private string _contactAddress;
    private int _finalWage;
    private static List<Resume> _instances = new List<Resume> {};

    public Resume (string businessName, string jobTitle, string jobDescription, string duration, int finalWage, string contactAddress, int contactNumber)
    {
      _businessName = businessName;
      _jobTitle = jobTitle;
      _jobDescription = jobDescription;
      _duration = duration;
      _contactNumber = contactNumber;
      _contactAddress = contactAddress;
      _finalWage = finalWage;
    }
    public string GetBusinessName()
    {
      return _businessName;
    }
    public void SetBusinessName(string newBusinessName)
    {
      _businessName = newBusinessName;
    }
    public string GetJobTitle()
    {
      return _jobTitle;
    }
    public void SetJobTitle(string newJobTitle)
    {
      _jobTitle = newJobTitle;
    }
    public string GetJobDescription()
    {
      return _jobDescription;
    }
    public void SetJobDescription(string newJobDescription)
    {
      _jobDescription = newJobDescription;
    }
    public string GetDuration()
    {
      return _duration;
    }
    public void SetDuration(string newDuration)
    {
      _duration = newDuration;
    }
    public string GetContactAddress()
    {
      return _contactAddress;
    }
    public void SetContactAddress(string newContactAddress)
    {
      _contactAddress = newContactAddress;
    }
    public int GetContactNumber()
    {
      return _contactNumber;
    }
    public void SetContactNumber(int newContactNumber)
    {
      _contactNumber = newContactNumber;
    }
    public int GetFinalWage()
    {
      return _finalWage;
    }
    public void SetFinalWage(int newFinalWage)
    {
      _finalWage = newFinalWage;
    }
    public static List<Resume> GetAll()
    {
      return _instances;
    }
    public void JobSave()
    {
      _instances.Add(this);
    }
  }

}
