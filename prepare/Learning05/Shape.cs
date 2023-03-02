using System;
using System.Collections.Generic;

public class Shape
{
   protected string _color;
   protected double _doubleVal;

   public Shape(string color)
   {
        _color = color;
   }

   public string GetColor()
   {        
        return _color;
   }

   public void SetColor(string color, double doubleVal)
   {
        _color = color;
        _doubleVal = doubleVal;
   }

   public virtual double GetArea()
   {
        return _doubleVal;
   }

}