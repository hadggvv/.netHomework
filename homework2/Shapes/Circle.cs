using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {
  class Circle : Shape {
    private double radius;

    public Circle(double radius) {
      Radius = radius;
    }

    public double Radius {
      get { return radius; }
      set {
        radius = value;
        if (!Verify()) throw new ArgumentOutOfRangeException("Invalid Circle");
      }
    }

    public string Info => $"Circle:radius={radius}";

    public double Area => Math.PI * radius * radius;

    public bool Verify() {
      return radius > 0;
    }
  }
}
