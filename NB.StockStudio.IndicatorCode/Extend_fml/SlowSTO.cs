﻿// Decompiled with JetBrains decompiler
// Type: FML.Extend.SlowSTO
// Assembly: Extend_fml, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 80B8D39B-C1FC-4273-9C0E-5AD2F813E720
// Assembly location: E:\Development\TradingProjects\Easy Financial Chart3.5 .net 4.5\StockExpert\NB.StockStudio\bin\Debug\dllReference\formula\Extend_fml.dll

using NB.StockStudio.Foundation;
using NB.StockStudio.Foundation.DataProvider;

namespace FML.Extend
{
  public class SlowSTO : FormulaBase
  {
    private double N;
    private double M1;
    private double M2;

    public SlowSTO()
    {
      base.\u002Ector();
      this.AddParam("N", 14.0, 1.0, 100.0);
      this.AddParam("M1", 3.0, 1.0, 50.0);
      this.AddParam("M2", 9.0, 1.0, 50.0);
    }

    public virtual FormulaPackage Run(IDataProvider dp)
    {
      this.DataProvider = (__Null) dp;
      FormulaData formulaData1 = FormulaData.op_Multiply(FormulaData.op_Division(FormulaData.op_Subtraction(this.get_C(), FormulaBase.LLV(this.get_L(), this.N)), FormulaData.op_Subtraction(FormulaBase.HHV(this.get_H(), this.N), FormulaBase.LLV(this.get_L(), this.N))), FormulaData.op_Implicit(100.0));
      formulaData1.Name = (__Null) "A";
      FormulaData formulaData2 = FormulaBase.MA(formulaData1, this.M1);
      formulaData2.Name = (__Null) "K";
      formulaData2.SetAttrs("COLORDARKGREEN,WIDTH2,HIGHQUALITY");
      FormulaData formulaData3 = FormulaBase.MA(formulaData2, this.M2);
      formulaData3.Name = (__Null) "D";
      FormulaData formulaData4 = this.PARTLINE(FormulaData.op_GreaterThanOrEqual(formulaData2, formulaData3), formulaData2);
      formulaData4.SetAttrs("COLORRED,WIDTH2,HIGHQUALITY");
      return new FormulaPackage(new FormulaData[3]
      {
        formulaData2,
        formulaData3,
        formulaData4
      }, "");
    }
  }
}
