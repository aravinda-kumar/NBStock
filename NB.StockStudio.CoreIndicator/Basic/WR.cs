﻿// Decompiled with JetBrains decompiler
// Type: FML.WR
// Assembly: Basic_fml, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E9284717-8834-4B37-BC08-9823918209B3
// Assembly location: E:\Development\TradingProjects\Easy Financial Chart3.5 .net 4.5\StockExpert\NB.StockStudio\bin\Debug\dllReference\formula\Basic_fml.dll

using NB.StockStudio.Foundation;
using NB.StockStudio.Foundation.DataProvider;

namespace FML
{
  public class WR : FormulaBase
  {
    private double N;

    public WR()
    {
      base.\u002Ector();
      this.AddParam("N", 14.0, 2.0, 100.0);
    }

    public virtual FormulaPackage Run(IDataProvider dp)
    {
      this.DataProvider = (__Null) dp;
      return new FormulaPackage(new FormulaData[1]
      {
        FormulaData.op_Division(FormulaData.op_Multiply(FormulaData.op_Implicit(100.0), FormulaData.op_Subtraction(FormulaBase.HHV(this.get_HIGH(), this.N), this.get_CLOSE())), FormulaData.op_Subtraction(FormulaBase.HHV(this.get_HIGH(), this.N), FormulaBase.LLV(this.get_LOW(), this.N)))
      }, "");
    }
  }
}
