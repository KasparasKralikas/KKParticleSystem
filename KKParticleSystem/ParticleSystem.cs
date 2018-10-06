using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKParticleSystem
{
    class ParticleSystem
    {
        private int emitRate;

        public int EmitRate { get; set; }

        private float counter = 0;

        public List<Particle> particles;

        public ParticleSystem(int emitRate)
        {
            this.emitRate = emitRate;
            particles = new List<Particle>();
        }

        public void Update(float deltaTime)
        {

            int count = (int) (deltaTime * emitRate);
            for (int i = 0; i < count; i++)
            {
                float random = (float)(new Random()).Next(0, 100) / 10;
                Particle particle = new Particle(new PointF(200, 50), new PointF(0, -20), random, new PointF(2, 2), new PointF(random, 10));
                particles.Add(particle);
            }

            foreach(Particle particle in particles.ToList())
            {
                if (particle.Update(deltaTime))
                {
                    particles.Remove(particle);
                }
            }
        }



        
    }
}
