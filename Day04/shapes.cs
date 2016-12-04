// shapes.cs
// compile with: /target:library /reference:abstractshape.dll

using System;

// Shapeクラスから派生させる
public class Square : Shape
{
    private int mySide;

    // Squareのコンストラクタを実行する前に、
    // 基本クラスのコンストラクタ Shape(string s)を呼び出す
    // https://msdn.microsoft.com/ja-jp/library/hfw7t1ce.aspx
    public Square(int side, string id) : base(id)
    {
        Console.WriteLine("Square()");
        mySide = side;
    }

    // 基本クラスのプロパティAreaをoverrideする
    public override double Area
    {
        get
        {
            // Given the side, return the area of a square:
            return mySide * mySide;
        }
    }
}

public class Circle : Shape
{
    private int myRadius;

    public Circle(int radius, string id) : base(id)
    {
        Console.WriteLine("Circle()");
        myRadius = radius;
    }

    public override double Area
    {
        get
        {
            // Given the radius, return the area of a circle:
            return myRadius * myRadius * System.Math.PI;
        }
    }
}

public class Rectangle : Shape
{
    private int myWidth;
    private int myHeight;

    public Rectangle(int width, int height, string id) : base(id)
    {
        Console.WriteLine("Rectangle()");
        myWidth = width;
        myHeight = height;
    }

    public override double Area
    {
        get
        {
            // Given the width and height, return the area of a rectangle:
            return myWidth * myHeight;
        }
    }
}