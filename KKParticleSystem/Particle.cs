using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKParticleSystem
{
    class Particle
    {
        public PointF position;

        public PointF velocity;

        public float lifetime;

        public PointF size;

        public PointF acceleration;

        public Particle(PointF position, PointF velocity, float lifetime, PointF size, PointF acceleration)
        {
            this.position = position;
            this.velocity = velocity;
            this.lifetime = lifetime;
            this.size = size;
            this.acceleration = acceleration;
        }

        public bool Update(float deltaTime)
        {
            position = new PointF(position.X + velocity.X * deltaTime, position.Y + velocity.Y * deltaTime);
            velocity = new PointF(velocity.X + acceleration.X * deltaTime, velocity.Y + acceleration.Y * deltaTime);
            lifetime -= deltaTime;
            return lifetime <= 0;
            
        }
    }
}
