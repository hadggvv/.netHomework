﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework3 {
  class Program {
    static void Main(string[] args) {
      try {
        List<Shape> shapes = new List<Shape>();
        for (int i = 0; i < 10; i++) {
          shapes.Add(ShapeFactory.CreateRandomShape());
        }


        foreach (Shape shape in shapes)
          Console.WriteLine(shape.Info + $"{shape.Info}, area={shape.Area}");
      }
      catch (Exception e) {
        Console.WriteLine(e.Message);
      }
    }
  }
}
