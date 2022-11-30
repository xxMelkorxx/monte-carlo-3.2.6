using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monte_carlo
{
    public class MonteCarlo
    {
        private int CountParticles => _particles.Count;
        private int _initCountParticles;

        private double _radius;
        private double _lambda;

        private double ProbScattering { get; }
        private double ProbAbsorption { get; }
        private double ProbDivision => ProbScattering - ProbAbsorption;

        private List<Particle> _particles;

        private Random _random;

        public MonteCarlo(int countParticles, double radius)
        {
            _initCountParticles = countParticles;
            _radius = radius;

            _random = new Random(DateTime.Now.Millisecond);
            _particles = new List<Particle>();
            for (var i = 0; i < _initCountParticles; i++)
            {
                var rnd = 2 * Math.PI * _random.NextDouble();
                _particles.Add(new Particle(new Vector2D(Math.Cos(rnd), Math.Sin(rnd) * _radius)));
            }
        }

        public void MonteCarloStep()
        {
            var rnd = _random.NextDouble();
            if (rnd < ProbScattering)
            {
                
            }
            else if (rnd > ProbScattering && rnd < ProbAbsorption)
            {
                
            }
            else
            {
                
            }
        }
    }

    public struct Particle
    {
        public Vector2D Position;
        public Vector2D SpeedDirection;

        public Particle(Vector2D position)
        {
            Position = position;
            SpeedDirection = Vector2D.Zero;
        } 
    }
}