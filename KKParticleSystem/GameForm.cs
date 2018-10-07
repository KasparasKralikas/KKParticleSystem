using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KKParticleSystem
{
    public partial class GameForm : Form
    {
        Bitmap Backbuffer;

        float delta = 0;

        int emitRate = 8000;

        Stopwatch stopwatch;

        ParticleSystem particleSystem;

        public GameForm()
        {
            InitializeComponent();

            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            Application.Idle += HandleApplicationIdle;

            this.Paint += HandleFormPaint;
            this.ResizeEnd += new EventHandler(CreateBackBuffer);
            this.Load += new EventHandler(CreateBackBuffer);

            stopwatch = Stopwatch.StartNew();

            particleSystem = new ParticleSystem(emitRate);
        }

        //Game Update function for all the game logic
        void GameUpdate(float deltaTime)
        {
            particleSystem.Update(delta);
        }

        //Game Render function to draw all the particles
        void GameRender()
        {
            if (Backbuffer != null)
            {
                using (var g = Graphics.FromImage(Backbuffer))
                {
                    g.Clear(Color.Black);

                    foreach(Particle particle in particleSystem.particles)
                    {
                        int index = particle.ID;
                        g.FillRectangle(Brushes.Red, particleSystem.positions[index].X, particleSystem.positions[index].Y, particleSystem.sizes[index].X, particleSystem.sizes[index].Y);
                    }
                }

                Invalidate();
            }
        }

        private void CreateBackBuffer(object sender, EventArgs e)
        {
            if (Backbuffer != null)
                Backbuffer.Dispose();

            Backbuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        void HandleFormPaint(object sender, PaintEventArgs e)
        {
            if (Backbuffer != null)
            {
                e.Graphics.DrawImageUnscaled(Backbuffer, Point.Empty);

            }
        }

        void HandleApplicationIdle(object sender, EventArgs e)
        {
            while (IsApplicationIdle())
            {
                delta = (float)stopwatch.Elapsed.TotalSeconds;
                deltaLabel.Text = "FPS: " + (1 / delta).ToString("n2");
                particlesLabel.Text = "Count: " + particleSystem.particles.Count.ToString();
                stopwatch = Stopwatch.StartNew();
                GameUpdate(delta);
                GameRender();
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        bool IsApplicationIdle()
        {
            NativeMessage result;
            return PeekMessage(out result, IntPtr.Zero, (uint)0, (uint)0, (uint)0) == 0;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NativeMessage
        {
            public IntPtr Handle;
            public uint Message;
            public IntPtr WParameter;
            public IntPtr LParameter;
            public uint Time;
            public Point Location;
        }

        [DllImport("user32.dll")]
        public static extern int PeekMessage(out NativeMessage message, IntPtr window, uint filterMin, uint filterMax, uint remove);

        private void deltaLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

