using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Scripts
{
    public class ShapeFactory
    {
        public Shape this[ShapeType type]
        {
            get
            {
                switch (type)
                {
                    case ShapeType.Circle:
                        return new Circle();
                    case ShapeType.Rectangle:
                        return new Rectangle();
                    case ShapeType.Square:
                        return new Square();
                    default:
                        return null;
                }
            }
        }
    }
}
