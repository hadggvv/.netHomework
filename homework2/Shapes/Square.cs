using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {
  class Square : Shape {

    private double width;

    public Square(double width) {
      Width = width;
    }

    public double Width {
      get { return width; }
      set {
        width = value;
        if (!Verify()) throw new ArgumentOutOfRangeException("Invalid Square Width");
      }
    }

    public string Info => $"Square:width={width}.";

    public double Area => width * width;

    public bool Verify() {
      return width > 0;
    }
  }
}
