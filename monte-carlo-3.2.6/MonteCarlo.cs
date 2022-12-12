using System;
using System.Collections.Generic;

namespace monte_carlo
{
    public class MonteCarlo
    {
        /// <summary>
        /// Вероятность рассеяния.
        /// </summary>
        public double Ps => 1 - Pa - Pd;

        /// <summary>
        /// Вероятность поглощения.
        /// </summary>
        public double Pa { get; set; }

        /// <summary>
        /// Вероятность деления.
        /// </summary>
        public double Pd { get; set; }

        public List<Vector2D> Particles;
        public int CountParticles => Particles.Count;
        public int CountEjectedParticles;
        public int CountAbsorbedParticles;

        private double _radius;
        private double _lambda;
        private Random _random;
        private const double Pi2 = 2 * Math.PI;

        public MonteCarlo(int countParticles, double radius)
        {
            _radius = radius;
            _lambda = 1;

            _random = new Random(DateTime.Now.Millisecond);
            Particles = new List<Vector2D>();
            for (var i = 0; i < countParticles; i++)
            {
                var rnd = 2 * Math.PI * _random.NextDouble();
                Particles.Add(new Vector2D(Math.Cos(rnd), Math.Sin(rnd)) * _random.NextDouble() * _radius);
            }
        }

        /// <summary>
        /// Монте-Карло шаг.
        /// </summary>
        public void MonteCarloStep(bool isEven)
        {
            var initCount = Particles.Count;

            for (var i = 0; i < initCount; i++)
            {
                var rScenario = _random.NextDouble();

                if (rScenario <= Ps)
                {
                    var r1 = Pi2 * _random.NextDouble();
                    var r2 = Pi2 * _random.NextDouble();
                    var l = -_lambda * Math.Log(r1);
                    if ((Particles[i] += l * new Vector2D(Math.Cos(r2), Math.Sin(r2))).SquaredMagnitude() >= _radius * _radius)
                    {
                        Particles.RemoveAt(i);
                        CountEjectedParticles++;
                        i--;
                        initCount--;
                    }
                }
                else if (rScenario >= Ps && rScenario <= Ps + Pa)
                {
                    Particles.RemoveAt(i);
                    CountAbsorbedParticles++;
                    i--;
                    initCount--;
                }
                else if (rScenario > Ps + Pa)
                {
                    for (var j = 0; j < (isEven ? 3 : 2); j++)
                        Particles.Add(Particles[i]);
                    Particles.RemoveAt(i);
                    i--;
                    initCount--;
                }
            }
        }
    }
}