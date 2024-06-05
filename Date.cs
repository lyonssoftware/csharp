// c# example of using dates 
Using System;
class Date 
{
  public static void Main()
    {
    // create new date object dt and initialize date 2021-01-01 16:05:07.123
    DateTime dt = new DateTime(2021, 1, 1, 16, 5, 7, 123);

    // new format of the date 
    String.Format("{0:y yy yyy yyyy}", dt);  // "8 08 008 2008"   year
    // new format of the date with the date first
    String.Format("{0:M MM MMM MMMM}", dt); 
    // "3 03 Mar March"  month
    String.Format("{0:d dd ddd dddd}", dt);  // "9 09 Sun Sunday" day
    String.Format("{0:h hh H HH}",     dt);  // "4 04 16 16"      hour 12/24
    // format the minute 
    String.Format("{0:m mm}",          dt);  // "5 05"            minute

// new format 
    String.Format("{0:s ss}",          dt);  // "7 07"            second
    String.Format("{0:f ff fff ffff}", dt);  // "1 12 123 1230"   sec.fraction
    String.Format("{0:F FF FFF FFFF}", dt);  // "1 12 123 123"    without zeroes
    String.Format("{0:t tt}",          dt);  // "P PM"            A.M. or P.M.
    String.Format("{0:z zz zzz}",      dt);  // "-6 -06 -06:00"   time zone
    }
} // end of program 
