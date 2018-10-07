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
                Random random = new Random();
                float randomFloat = random.Next(-180, 180) / 10;
                Particle particle = new Particle(new PointF(random.Next(240, 260), 150), new PointF(random.Next(-30, 30), -random.Next(40,60)), random.Next(6, 9), new PointF(4, 4), new PointF(0, 20));
                particles.Add(particle);
            }

            List<Particle> removeList = new List<Particle>();

            foreach(Particle particle in particles)
            {
                if (particle.Update(deltaTime))
                {
                    removeList.Add(particle);
                }
            }

            foreach(Particle particle in removeList)
            {
                particles.Remove(particle);
            }
        }



        
    }
}
