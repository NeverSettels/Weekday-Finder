using System;
using System.Linq;

namespace WF.Models
{
  public class Week
  {
    // 5/13/2020 
    public static DayOfWeek GetWeekday(string date)
    {
      string[] dateArr = date.Split("/");
      DateTime dt = new DateTime(int.Parse(dateArr[2]), int.Parse(dateArr[0]), int.Parse(dateArr[1]));
      //Console.WriteLine(dt.DayOfWeek);
      return dt.DayOfWeek;
    }

    public static void Main()
    {
      DayOfWeek weekday = GetWeekday("5/13/2020");
      Console.WriteLine(weekday);
    }
  }
}