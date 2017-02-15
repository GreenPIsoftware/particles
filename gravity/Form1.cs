using SharpDX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gravity
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Generates a random, circular force
        /// </summary>
        /// <param name="rand"></param>
        /// <param name="XMin"></param>
        /// <param name="XMax"></param>
        /// <param name="YMin"></param>
        /// <param name="YMax"></param>
        /// <returns></returns>
        Vector2 GetRandForce(Random rand, float XMin, float XMax, float YMin, float YMax)
        {
            var angle = rand.Next(360) / Math.PI * 2;
            return new Vector2((float)Math.Cos(angle) * rand.NextFloat(XMin, XMax), (float)Math.Sin(angle) * rand.NextFloat(YMin, YMax));
        }

        public Form1()
        {
            InitializeComponent();
        }

        List<Particle2D> Particles = new List<Particle2D>();
        Random rand = new Random(DateTime.Now.Millisecond);
        Stopwatch sw = new Stopwatch();
        List<Vector2> Spawns = new List<Vector2>();
        Bitmap back = new Bitmap(1920, 1080);
        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas.BackgroundImage = back;
            sw.Start();
        }

        bool InvertForce = false;
        private void Update_Tick(object sender, EventArgs e)
        {
            foreach (var spawn in Spawns)
            {
                // 1/10 chance of particle spawning
                if (rand.Next(10) > 0)
                    continue;

                if (!CB_randrange.Checked)
                    Particles.Add(new Particle2D(spawn, new Vector2((float)NUD_forcex.Value, (float)NUD_forcey.Value), Spawns.IndexOf(spawn), rand));
                else
                    Particles.Add(new Particle2D(spawn, GetRandForce(rand, -(float)Math.Abs(NUD_forcex.Value), (float)Math.Abs(NUD_forcex.Value), (float)Math.Abs(NUD_forcey.Value), (float)Math.Abs(NUD_forcey.Value)), Spawns.IndexOf(spawn), rand));
            }

            float Gravity = (float)NUD_gravity.Value;
            if (InvertForce)
                Gravity *= -1f;

            List<Particle2D> temp = new List<Particle2D>();
            foreach (var p in Particles)
            {
                p.ApplyForce(Particles, Gravity);
                p.Update();

                // kill particles that leave the canvas
                if (p.pos.X < 0 || p.pos.X > Canvas.Width || p.pos.Y < 0 || p.pos.Y > Canvas.Height)
                    temp.Add(p);
            }
            foreach (var p in temp)
                Particles.Remove(p);

            Canvas.Refresh();
        }

        
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Canvas.BackgroundImage = back;
            Graphics g = Graphics.FromImage(back);
            foreach (var p in Particles)
            {
                p.Draw(e.Graphics, true);
                g.DrawLine(Pens.DimGray, p.oldpos.ToPointF(), p.pos.ToPointF());
            }
            g.Dispose();
            e.Graphics.DrawString("Particles alive: " + Particles.Count.ToString() + "\nFPS: " + (1000 / sw.ElapsedMilliseconds).ToString() + "\nactive Spawns: " + Spawns.Count.ToString(), this.Font, Brushes.Red, 10, 10);
            sw.Restart();  
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Spawns.Add(e.Location.ToVector2());
            else if (e.Button == MouseButtons.Middle)
                t_Update.Enabled = !t_Update.Enabled;
            else if(e.Button == MouseButtons.Right && Spawns.Count > 0)
                Spawns.RemoveAt(0);
        }

        private void BTN_clr_Click(object sender, EventArgs e)
        {
            back = new Bitmap(1920, 1080);
            Particles.Clear();
            Spawns.Clear();
        }
    }
}
