using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace gravity
{
    public class Particle2D
    {
        public Vector2 pos, force, oldpos;
        float Diam = 5;
        int TrailLen;
        List<Vector2> Trail = new List<Vector2>();
        public int Team = 0;
        Pen TailPen;

        private Pen PickBrush(Random rnd)
        {
            Pen result = Pens.Transparent;
            Type brushesType = typeof(Pens);
            PropertyInfo[] properties = brushesType.GetProperties();
            int random = rnd.Next(properties.Length);
            result = (Pen)properties[random].GetValue(null, null);
            return new Pen(result.Color, 2);
        }

        public Particle2D(Vector2 _pos, Vector2 _force, int _Team, Random rnd, int _trailLen = 5)
        {
            pos = _pos; oldpos = force = _force; TrailLen = _trailLen; Team = _Team;
            TailPen = PickBrush(rnd);
        }

        public void ApplyForce(Vector2 f)
        {
            force += f;
        }

        public void ApplyForce(List<Particle2D> f, float Gravity)
        {
            foreach (Particle2D p in f)
            {
                if (p.Team == Team)
                    continue;
                force += (p.pos - pos) * (Gravity / ((p.pos - pos).LengthSquared()));
            }
        }

        public void Update(float smooth = 1f)
        {
            oldpos = pos;
            pos += force / smooth;
            Trail.Add(pos);
            if (Trail.Count > TrailLen)
            {
                Trail.RemoveAt(0);
            }
        }

        public void Draw(Graphics g, bool DrawTrail = false)
        {
            if (Trail.Count > 2)
                g.DrawLines(TailPen, Trail.ToPointF().ToArray());
            if (!DrawTrail)
                return;
            //g.FillEllipse(Brushes.Tomato, pos.X - Diam / 2f, pos.Y - Diam / 2f, Diam, Diam);
        }
    }
}
