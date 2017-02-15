using SharpDX;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravity
{
    public static class Extensions
    {
        public static PointF ToPointF(this Vector2 v)
        {
            return new PointF(v.X, v.Y);
        }

        public static Vector2 ToVector2(this System.Drawing.Point v)
        {
            return new Vector2(v.X, v.Y);
        }

        public static List<PointF> ToPointF(this List<Vector2> v)
        {
            return v.Select(x => new PointF() { X = x.X, Y = x.Y }).ToList();
        }
    }
}
