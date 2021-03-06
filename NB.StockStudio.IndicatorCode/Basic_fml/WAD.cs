﻿// Decompiled with JetBrains decompiler
// Type: FML.WAD
// Assembly: Basic_fml, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E9284717-8834-4B37-BC08-9823918209B3
// Assembly location: E:\Development\TradingProjects\Easy Financial Chart3.5 .net 4.5\StockExpert\NB.StockStudio\bin\Debug\dllReference\formula\Basic_fml.dll

using NB.StockStudio.Foundation;
using NB.StockStudio.Foundation.DataProvider;

namespace FML
{
  public class WAD : FormulaBase
  {
    public WAD()
    {
      base.\u002Ector();
    }

    public virtual FormulaPackage Run(IDataProvider dp)
    {
      this.DataProvider = (__Null) dp;
      return new FormulaPackage(new FormulaData[1]
      {
        FormulaBase.SUM(FormulaBase.IF(FormulaData.op_GreaterThan(this.get_CLOSE(), FormulaBase.REF(this.get_CLOSE(), 1.0)), FormulaData.op_Subtraction(this.get_CLOSE(), FormulaBase.MIN(new FormulaData[2]
        {
          FormulaBase.REF(this.get_CLOSE(), 1.0),
          this.get_LOW()
        })), FormulaBase.IF(FormulaData.op_LessThan(this.get_CLOSE(), FormulaBase.REF(this.get_CLOSE(), 1.0)), FormulaData.op_Subtraction(this.get_CLOSE(), FormulaBase.MAX(new FormulaData[2]
        {
          FormulaBase.REF(this.get_CLOSE(), 1.0),
          this.get_HIGH()
        })), FormulaData.op_Implicit(0.0))), 0.0)
      }, "");
    }
  }
}
