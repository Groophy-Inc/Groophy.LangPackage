## LangPackage

[![NuGet version (Groophy.LangPackage)](https://img.shields.io/nuget/v/Newtonsoft.Json.svg?style=flat-square)](https://www.nuget.org/packages/Groophy.LangPackage/)

# Usage

We create a class varriable
```c#
Lang l = new Lang();
```

After read lang file
```c#
l.ReadLang("C:\\Users\\<username>\\Desktop\\test.lang");
//BatchIDE=Groophy.Inc
//bat=kvc/*owner of batch-man*/
```

Lastly get value
```c#
l["<PropertiesName>"]

Console.WriteLine(l["BatchIDE"] + " - " + l["bat"]);
//Groophy.Inc - kvc
```

# Sample

```c#
Lang l = new Lang();
l.ReadLang("C:\\Users\\<username>\\Desktop\\test.lang");
//BatchIDE=Groophy.Inc
//bat=kvc/*owner of batch-man*/

Console.WriteLine(l["BatchIDE"] + " - " + l["bat"]);
//Groophy.Inc - kvc

Console.ReadKey();
```
