using System;


/***********OPERAÇÕES DATE TIME************/
/*DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
Console.WriteLine(d);
Console.WriteLine("1) Date: " + d.Date);
Console.WriteLine("2) Day: " + d.Day);
Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
Console.WriteLine("5) Hour: " + d.Hour);
Console.WriteLine("6) Kind: " + d.Kind);
Console.WriteLine("7) Millisecond: " + d.Millisecond);
Console.WriteLine("8) Minute: " + d.Minute);
Console.WriteLine("9) Month: " + d.Month);
Console.WriteLine("10) Second: " + d.Second);
Console.WriteLine("11) Ticks: " + d.Ticks);
Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
Console.WriteLine("13) Year: " + d.Year);

string s1 = d.ToLongDateString();
string s2 = d.ToLongTimeString();
string s3 = d.ToShortDateString();
string s4 = d.ToShortTimeString();

string s5 = d.ToString();

string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);
Console.WriteLine(s5);
Console.WriteLine(s6);
Console.WriteLine(s7);


DateTime y = DateTime.Now;
DateTime z = y.AddDays(7);

DateTime d = new DateTime(1994, 09, 24);
DateTime e = new DateTime(1994, 09, 30);

DateTime d2 = x.AddDays(3);
DateTime d3 = x.AddHours(2);
DateTime d4 = x.AddMilliseconds(300);
DateTime d5 = x.AddMinutes(3);
DateTime d6 = x.AddMonths(2);
DateTime d7 = x.AddSeconds(2);
DateTime d8 = x.AddTicks(300);
DateTime d9 = x.AddYears(5);

TimeSpan m = e.Subtract(d);

Console.WriteLine(x);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);
Console.WriteLine(d6);
Console.WriteLine(d7);
Console.WriteLine(d8);
Console.WriteLine(d9);
Console.WriteLine();
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine();
Console.WriteLine(m);*/


/**************TIME SPAN***********/
/*TimeSpan t1 = TimeSpan.MaxValue;
TimeSpan t2 = TimeSpan.MinValue;
TimeSpan t3 = TimeSpan.Zero;

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);

TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

Console.WriteLine();
Console.WriteLine(t);
Console.WriteLine("Days: " + t.Days);
Console.WriteLine("Hours: " + t.Hours);
Console.WriteLine("Minutes: " + t.Minutes);
Console.WriteLine("Milliseconds: " + t.Milliseconds);
Console.WriteLine("Seconds: " + t.Seconds);
Console.WriteLine("Ticks: " + t.Ticks);
Console.WriteLine("TotalDays: " + t.TotalDays);
Console.WriteLine("TotalHours: " + t.TotalHours);
Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

//OPERAÇÕES TIMESPAN

TimeSpan time1 = new TimeSpan(1, 30, 10);
TimeSpan time2 = new TimeSpan(0, 10, 5);

TimeSpan sum = time1.Add(time2);
TimeSpan sub= time1.Subtract(time2);
TimeSpan mult = time2.Multiply(2.0);
TimeSpan div = time2.Divide(2.0);

Console.WriteLine(sum);
Console.WriteLine(sub);
Console.WriteLine(mult);
Console.WriteLine(div);*/

/*******DATE TIME KIND E PADRAO ISO 8601***********/
/*DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

Console.WriteLine("d1: " + d1);
Console.WriteLine("d1 Kind: " + d1.Kind);
Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
Console.WriteLine();
Console.WriteLine("d2: " + d2);
Console.WriteLine("d2 Kind: " + d2.Kind);
Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
Console.WriteLine();
Console.WriteLine("d3: " + d3);
Console.WriteLine("d3 Kind: " + d3.Kind);
Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
Console.WriteLine();

DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

Console.WriteLine("d1: " + d1);
Console.WriteLine("d1 Kind: " + d1.Kind);
Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
Console.WriteLine();
Console.WriteLine("d2: " + d2);
Console.WriteLine("d2 Kind: " + d2.Kind);
Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
Console.WriteLine();
Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado
Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));*/