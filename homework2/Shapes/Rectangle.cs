using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {
  class Rectangle : Shape {
    private double length;

    private double width;

    public Rectangle(double length, double width) {
      Length = length;
      Width = width;
      if (!Verify()) throw new ArgumentOutOfRangeException("Invalid Rectangle");
    }



    public double Length {
      get { return length; }
      set {
        if (value < 0) throw new ArgumentOutOfRangeException("Invalid Rectangle Length");
        length = value;
      }
    }

    public double Width {
      get { return width; }
      set {
        if (value < 0) throw new ArgumentOutOfRangeException("Invalid Rectangle Width");
        width = value;
      }
    }

    public string Info => $"Rectangle:length={length},width={width}.";

    public double Area => length * width;


    public bool Verify() {
      return length > 0 && width > 0;
    }
  }
}
