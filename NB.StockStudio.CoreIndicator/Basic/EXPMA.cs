﻿// Decompiled with JetBrains decompiler
// Type: FML.EXPMA
// Assembly: Basic_fml, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E9284717-8834-4B37-BC08-9823918209B3
// Assembly location: E:\Development\TradingProjects\Easy Financial Chart3.5 .net 4.5\StockExpert\NB.StockStudio\bin\Debug\dllReference\formula\Basic_fml.dll

using NB.StockStudio.Foundation;
using NB.StockStudio.Foundation.DataProvider;

namespace FML
{
  public class EXPMA : FormulaBase
  {
    private double P1;
    private double P2;
    private double P3;
    private double P4;

    public EXPMA()
    {
      base.\u002Ector();
      this.AddParam("P1", 5.0, 1.0, 300.0);
      this.AddParam("P2", 10.0, 1.0, 300.0);
      this.AddParam("P3", 20.0, 1.0, 300.0);
      this.AddParam("P4", 60.0, 1.0, 300.0);
    }

    public virtual FormulaPackage Run(IDataProvider dp)
    {
      this.DataProvider = (__Null) dp;
      FormulaData formulaData1 = FormulaBase.EMA(this.get_CLOSE(), this.P1);
      formulaData1.Name = (__Null) "MA1";
      FormulaData formulaData2 = FormulaBase.EMA(this.get_CLOSE(), this.P2);
      formulaData2.Name = (__Null) "MA2";
      FormulaData formulaData3 = FormulaBase.EMA(this.get_CLOSE(), this.P3);
      formulaData3.Name = (__Null) "MA3";
      FormulaData formulaData4 = FormulaBase.EMA(this.get_CLOSE(), this.P4);
      formulaData4.Name = (__Null) "MA4";
      return new FormulaPackage(new FormulaData[4]
      {
        formulaData1,
        formulaData2,
        formulaData3,
        formulaData4
      }, "");
    }
  }
}
