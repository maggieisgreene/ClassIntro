using System;

namespace ClassIntro
{
  public class Car
  {
    // Field
    // Fields don't have a get; set; and are typically private
    private int _mileage = 0;

    // Properties
    // Properties have a get; set; are typically public 
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool NeedsMaintenance { get; set; } = false;
    public bool IsClean { get; set; } = false;

    // Computed properties
    // Read only -- cannot be set
    public string Description
    {
      get
      {
        return $"{Year} {Make} {Model}";
      }
    }

    // Methods
    public void Drive(int miles)
    {
      _mileage += miles;

      if (_mileage > 10000)
      {
        NeedsMaintenance = true;
      }
    }

    public void Service()
    {
      NeedsMaintenance = false;
    }

    // Method overloading
    // Shares a method name, but has different arguments
    public void Service(bool addCleaningService)
    {
      NeedsMaintenance = false;
      IsClean = true;
    }

    // Constructor
    // It doesn't have a return type and the name of the method is the same as the class name
    public Car(int mileage)
    {
      _mileage = mileage;
    }

    public Car(int mileage, string make, string model, int year)
    {
      _mileage = mileage;
      Make = make;
      Model = model;
      Year = year;
    }
  }
}