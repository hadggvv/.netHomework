using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {

  class ShapeFactory {

    static Random random = new Random();

    public static Shape CreateShape(string type, params double[] edges) {
      switch (type) {
        case "squre": return new Square(edges[0]);
        case "circle": return new Circle(edges[0]);
        case "rectangle": return new Rectangle(edges[0], edges[1]);
        case "triangle": return new Triangle(edges[0], edges[1], edges[2]);
        default: throw new InvalidOperationException("Invalid shape type:" + type);
      }
    }

    public static Shape CreateRandomShape() {
      int type = random.Next(0, 4);
      Shape result = null;
      while (result==null) {
        try {
          switch (type) {
            case 0:
              result = CreateShape("squre", random.Next(200));
              break;
            case 1:
              result = CreateShape("circle", random.Next(200));
              break;
            case 2:
              result = CreateShape("rectangle", random.Next(200), random.Next(200));
              break;
            case 3:
              result = CreateShape("triangle", random.Next(200), random.Next(200), random.Next(200));
              break;
          }
        }catch {}
      }
      return result;
    }
  }
}
