using System.Collections.Generic;


namespace Tomogatchi.Objects
{
  public class userTomogatchi
  {
    private string _name;
    private int _id;
    private int _food;
    private int _attention;
    private int _rest;
    private static List<userTomogatchi> _instances = new List<userTomogatchi> {};

    public userTomogatchi(string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
      _food = 60;
      _attention = 45;
      _rest = 30;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<userTomogatchi> GetAll()
   {
     return _instances;
   }
    public int GetFood()
    {
      return _food;
    }
    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public int GetAttention()
    {
      return _attention;
    }
    public void SetAttention(int newAttention)
    {
      _attention = newAttention;
    }
    public int GetRest()
    {
      return _rest;
    }
    public void SetRest(int newRest)
    {
      _rest = newRest;
    }
    public static userTomogatchi Find(int searchId)
   {
     return _instances[searchId-1];
   }
  }
}
