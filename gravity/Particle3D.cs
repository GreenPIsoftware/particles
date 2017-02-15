using SharpDX;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravity
{
    public class Particle3D
    {
        public Vector3 pos, force, oldpos;
        public float Diam = 10;
        int TrailLen;
        //List<Vector3> Trail = new List<Vector3>();


        public Particle3D(Vector3 _pos, Vector3 _force, int _trailLen = 10)
        {
            pos = _pos; oldpos = force = _force; TrailLen = _trailLen;
        }

        public void ApplyForce(Vector3 f)
        {
            force += f;
        }

        public void ApplyForce(List<Particle3D> f, float Gravity)
        {
            foreach (Particle3D p in f)
            {
                if (p == this)
                    continue;
                force += (p.pos - pos) * (Gravity / ((p.pos - pos).LengthSquared() + 1));
            }
        }

        public void Update(float smooth = 1f)
        {
            oldpos = pos;
            //Trail.Add(oldpos);
            //if (Trail.Count > TrailLen)
            //{
            //    Trail.RemoveAt(0);
            //}
            pos += force / smooth;
            Diam = 20 - pos.Z / 5f;
        }

        public void Draw(Graphics g, bool DrawTrail = false)
        {
            if (Diam > 200)
                return;
            g.FillEllipse(Brushes.Green, pos.X - Diam / 2f, pos.Y - Diam / 2f, Diam, Diam);
            g.DrawEllipse(Pens.Wheat, pos.X - Diam / 2f, pos.Y - Diam / 2f, Diam, Diam);
            //if (Trail.Count > 2)
            //    g.DrawLines(Pens.LightSalmon, Trail.ToPointF().ToArray());
        }
    }
}
