﻿using interfaces3.Devices;

Printer p = new Printer() { SerialNumber = 1080 };
p.ProcessDoc("My letter");
p.Print("My letter");
Scanner s = new Scanner() { SerialNumber = 2003 };
s.ProcessDoc("My Email");
Console.WriteLine(s.Scan());