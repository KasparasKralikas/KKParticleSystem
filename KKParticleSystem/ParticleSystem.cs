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
        private Queue<int> unusedIndexes;

        public PointF[] positions;

        public PointF[] velocities;

        public float[] lifetimes;

        public PointF[] sizes;

        public PointF[] accelerations;

        public int maxParticles = 60000;


        private int emitRate;

        public int EmitRate { get; set; }

        public List<Particle> particles;

        public ParticleSystem(int emitRate)
        {
            this.emitRate = emitRate;
            particles = new List<Particle>();
            unusedIndexes = new Queue<int>();
            for (int i = 0; i < maxParticles; i++)
            {
                unusedIndexes.Enqueue(i);
            }

            positions = new PointF[maxParticles];
            velocities = new PointF[maxParticles];
            lifetimes = new float[maxParticles];
            sizes = new PointF[maxParticles];
            accelerations = new PointF[maxParticles];
            
        }

        public void Update(float deltaTime)
        {

            int count = (int) (deltaTime * emitRate);
            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                float randomFloat = random.Next(-180, 180) / 10;
                if (unusedIndexes.Count != 0)
                {
                    Particle particle = new Particle(unusedIndexes.Dequeue());
                    int index = particle.ID;
                    positions[index] = new PointF(random.Next(240, 260), 150);
                    velocities[index] = new PointF(random.Next(-30, 30), -random.Next(40, 60));
                    lifetimes[index] = random.Next(6, 9);
                    sizes[index] = new PointF(4, 4);
                    accelerations[index] = new PointF(0, 20);
                    particles.Add(particle);
                }
            }

            List<Particle> removeList = new List<Particle>();

            foreach(Particle particle in particles)
            {
                int index = particle.ID;

                positions[index] = new PointF(positions[index].X + velocities[index].X * deltaTime, positions[index].Y + velocities[index].Y * deltaTime);
                velocities[index] = new PointF(velocities[index].X + accelerations[index].X * deltaTime, velocities[index].Y + accelerations[index].Y * deltaTime);
                lifetimes[index] -= deltaTime;

                if (lifetimes[index] <= 0)
                {
                    removeList.Add(particle);
                }
            }

            foreach(Particle particle in removeList)
            {
                unusedIndexes.Enqueue(particle.ID);
                particles.Remove(particle);
            }
        }



        
    }
}
