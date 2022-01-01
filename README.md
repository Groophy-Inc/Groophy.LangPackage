## LangPackage

[![NuGet version (Groophy.LangPackage)](https://img.shields.io/nuget/v/Groophy.LangPackage.svg?style=flat-square)](https://www.nuget.org/packages/Groophy.LangPackage/)

[Source Code](https://github.com/Groophy-Inc/Groophy.LangPackage/blob/main/Groophy.LangPackage.Test/Groophy.LangPackage/lang.cs)

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

# Note
/* = start comment

*/ = end comment

```bat=kvc/*owner of batch-man*/```

~Groophy Lifefor
Lang["bat"] = kvc

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
