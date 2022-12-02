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
        private int _countEjectedParticles;
        private int _countAbsorbedParticles;
        private List<Particle> _particles;

        private double _radius;
        private double _lambda;

        /// <summary>
        /// Вероятность рассеяния.
        /// </summary>
        public double Ps { get; set; }

        /// <summary>
        /// Вероятность поглощения.
        /// </summary>
        public double Pa { get; set; }

        /// <summary>
        /// Вероятность деления.
        /// </summary>
        public double Pd => 1d - Ps - Pa;

        private Random _random;

        private const double Pi2 = 2 * Math.PI;

        public MonteCarlo(int countParticles, double radius)
        {
            _initCountParticles = countParticles;
            _radius = radius;
            _lambda = 1;

            _random = new Random(DateTime.Now.Millisecond);
            _particles = new List<Particle>();
            for (var i = 0; i < _initCountParticles; i++)
            {
                var rnd = 2 * Math.PI * _random.NextDouble();
                _particles.Add(new Particle(
                    new Vector2D(Math.Cos(rnd), Math.Sin(rnd)) * _radius,
                    Pi2 * _random.NextDouble()));
            }
        }

        /// <summary>
        /// Монте-Карло шаг.
        /// </summary>
        public void MonteCarloStep()
        {
            for (var i = 0; i < _particles.Count; i++)
            {
                var p = _particles[i];
                var rScenario = _random.NextDouble();
                
                if (rScenario <= Ps)
                {
                    var rScater = _lambda * _random.NextDouble();
                    var rAngle = Pi2 * _random.NextDouble();
                    p.Position += rScater * new Vector2D(Math.Cos(rAngle), Math.Sin(rAngle));
                    p.SpeedDirection = rAngle;
                    if (p.Position.SquaredMagnitude() >= _radius * _radius)
                    {
                        _particles.Remove(p);
                        _countEjectedParticles++;
                        i--;
                    }
                }
                else if (rScenario >= Ps && rScenario <= Ps + Pa)
                {
                    _particles.Remove(p);
                    _countAbsorbedParticles++;
                    i--;
                }
                else if (rScenario > Ps + Pa)
                {
                    for (var j = 0; j < 2; j++)
                        _particles.Add(new Particle(p.Position, Pi2 * _random.NextDouble()));
                    _particles.Remove(p);
                    i--;
                }
            }
        }
    }

    public class Particle
    {
        public Vector2D Position;
        public double SpeedDirection;

        public Particle(Vector2D position, double speedDirection)
        {
            Position = position;
            SpeedDirection = speedDirection;
        }
    }
}