﻿// Decompiled with JetBrains decompiler
// Type: FML.VSTD
// Assembly: Basic_fml, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E9284717-8834-4B37-BC08-9823918209B3
// Assembly location: E:\Development\TradingProjects\Easy Financial Chart3.5 .net 4.5\StockExpert\NB.StockStudio\bin\Debug\dllReference\formula\Basic_fml.dll

using NB.StockStudio.Foundation;
using NB.StockStudio.Foundation.DataProvider;

namespace FML
{
  public class VSTD : FormulaBase
  {
    private double N;

    public VSTD()
    {
      base.\u002Ector();
      this.AddParam("N", 10.0, 1.0, 1000.0);
    }

    public virtual FormulaPackage Run(IDataProvider dp)
    {
      this.DataProvider = (__Null) dp;
      return new FormulaPackage(new FormulaData[1]
      {
        FormulaBase.STD(this.get_VOL(), this.N)
      }, "");
    }
  }
}
