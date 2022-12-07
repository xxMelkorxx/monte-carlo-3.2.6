using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monte_carlo
{
	public partial class MainForm : Form
	{
		private MonteCarlo _monteCarlo;
		private Drawing _drawing;
		private double _radius;
		private int _currStep;
		private int _countStep;

		public MainForm()
		{
			InitializeComponent();
		}

		private void OnClickButtonCreateModel(object sender, EventArgs e)
		{
			var initCountParticles = (int)nud_No.Value;
			var pa = (double)nud_Pa.Value;
			var pd = (double)nud_Pd.Value;

			_radius = (double)nud_Rl.Value;
			_monteCarlo = new MonteCarlo(initCountParticles, _radius) { Pa = pa, Pd = pd };
			_currStep = 0;
			_countStep = 0;

			_drawing = new Drawing(pB_model, -_radius, -_radius, _radius, _radius);
			_drawing.DrawNuclearReactor(_radius);
			_drawing.DrawParticles(_radius * 0.01, _monteCarlo.Particles);

			tB_countStep.Text = "0";
			tB_countParticles.Text = _monteCarlo.CountParticles.ToString();
			tB_countEjectedParticles.Text = "0";
			tB_countAbsorbedParticles.Text = "0";

			label_statusReactor.ForeColor = Color.Lime;
			label_statusReactor.Text = "В норме";

			button_start.Enabled = true;
		}

		private void OnClickButtonStart(object sender, EventArgs e)
		{
			if (button_start.Text == "Старт")
			{
				_monteCarlo.Pa = (double)nud_Pa.Value;
				_monteCarlo.Pd = (double)nud_Pd.Value;

				timer_mks.Interval = (int)nud_intervalTimer.Value;
				timer_mks.Start();

				button_start.Text = "Стоп";

			}
			else if (button_start.Text == "Стоп")
			{
				timer_mks.Stop();
				button_start.Text = "Старт";
			}
		}

		private void OnTickTimerMKS(object sender, EventArgs e)
		{
			if (_countStep - _currStep == nud_mks.Value)
			{
				OnClickButtonStart(null, null);
				_currStep = _countStep;

				return;
			}

			if (_monteCarlo.CountParticles >= (int)nud_No.Value * (int)nud_countBoom.Value * 0.5)
			{
				label_statusReactor.ForeColor = Color.Yellow;
				label_statusReactor.Text = "Состояние критическое!";
			}

			if (_monteCarlo.CountParticles >= nud_No.Value * nud_countBoom.Value)
			{
				label_statusReactor.ForeColor = Color.Red;
				label_statusReactor.Text = "Реактор уничтожен!";
				pB_model.ImageLocation = "boom.png";

				OnClickButtonStart(null, null);
				button_start.Enabled = false;

				return;
			}
			
			_countStep++;
			_monteCarlo.MonteCarloStep();
			_drawing = new Drawing(pB_model, -_radius, -_radius, _radius, _radius);
			_drawing.DrawNuclearReactor(_radius);
			_drawing.DrawParticles(_radius * 0.01, _monteCarlo.Particles);

			tB_countStep.Text = _countStep.ToString();
			tB_countParticles.Text = _monteCarlo.CountParticles.ToString();
			tB_countEjectedParticles.Text = _monteCarlo.CountEjectedParticles.ToString();
			tB_countAbsorbedParticles.Text = _monteCarlo.CountAbsorbedParticles.ToString();

			GC.Collect();
		}
	}
}