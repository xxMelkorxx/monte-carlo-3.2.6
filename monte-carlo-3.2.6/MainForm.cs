using System;
using System.Drawing;
using System.IO;
using System.Text;
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
		private bool _isAddCond;
		private string _data;

		public MainForm()
		{
			InitializeComponent();
			OnValueChangedCountBoom(null, null);
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
			_drawing.DrawParticles(_radius, _monteCarlo.Particles, initCountParticles * (int)nud_countBoom.Value);

			tB_countStep.Text = "0";
			tB_countParticles.Text = _monteCarlo.CountParticles.ToString();
			tB_countEjectedParticles.Text = "0";
			tB_countAbsorbedParticles.Text = "0";

			label_statusReactor.ForeColor = Color.Lime;
			label_statusReactor.Text = "В норме";

			// Графики.
			chart_сountParticles.Series[0].Points.Clear();
			chart_countEjectedParticles.Series[0].Points.Clear();
			chart_countAbsorbedParticles.Series[0].Points.Clear();
			chart_сountParticles.Series[0].Points.AddXY(_countStep, _monteCarlo.CountParticles);
			chart_countEjectedParticles.Series[0].Points.AddXY(_countStep, _monteCarlo.CountEjectedParticles);
			chart_countAbsorbedParticles.Series[0].Points.AddXY(_countStep, _monteCarlo.CountAbsorbedParticles);

			_data += string.Format("{0} {1} {2} {3}\n", _countStep, _monteCarlo.CountParticles, _monteCarlo.CountEjectedParticles, _monteCarlo.CountAbsorbedParticles);

			button_start.Enabled = true;
		}

		private void OnClickButtonStart(object sender, EventArgs e)
		{
			if (button_start.Text == "Старт")
			{
				_monteCarlo.Pa = (double)nud_Pa.Value;
				_monteCarlo.Pd = (double)nud_Pd.Value;
				_isAddCond = checkBox_addCond.Checked;

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

			// Статус реактора.
			var countBoom = (int)nud_No.Value * (int)nud_countBoom.Value;
			if (_monteCarlo.CountParticles == 0)
			{
				label_statusReactor.ForeColor = Color.White;
				label_statusReactor.Text = "Частицы отсутствуют!";

				OnClickButtonStart(null, null);
				button_start.Enabled = false;

				return;
			}
			if (_monteCarlo.CountParticles >= countBoom)
			{
				label_statusReactor.ForeColor = Color.Red;
				label_statusReactor.Text = "Реактор уничтожен!";
				pB_model.Image = pB_model.ErrorImage;

				OnClickButtonStart(null, null);
				button_start.Enabled = false;

				return;
			}
			if (_monteCarlo.CountParticles >= countBoom * 0.8)
			{
				label_statusReactor.ForeColor = Color.Yellow;
				label_statusReactor.Text = "Состояние критическое!";
			}
			progressBar_statusReactor.Value = _monteCarlo.CountParticles >= countBoom ? progressBar_statusReactor.Maximum : _monteCarlo.CountParticles;

			// МКШ.
			if (_isAddCond && _countStep % 2 == 0) _monteCarlo.MonteCarloStep(true);
			else _monteCarlo.MonteCarloStep(false);
			_countStep++;

			// Отрисовка.
			_drawing = new Drawing(pB_model, -_radius, -_radius, _radius, _radius);
			_drawing.DrawParticles(_radius, _monteCarlo.Particles, countBoom);

			// Вывод информации.
			tB_countStep.Text = _countStep.ToString();
			tB_countParticles.Text = _monteCarlo.CountParticles.ToString();
			tB_countEjectedParticles.Text = _monteCarlo.CountEjectedParticles.ToString();
			tB_countAbsorbedParticles.Text = _monteCarlo.CountAbsorbedParticles.ToString();

			// Графики.
			chart_сountParticles.Series[0].Points.AddXY(_countStep, _monteCarlo.CountParticles);
			chart_countEjectedParticles.Series[0].Points.AddXY(_countStep, _monteCarlo.CountEjectedParticles);
			chart_countAbsorbedParticles.Series[0].Points.AddXY(_countStep, _monteCarlo.CountAbsorbedParticles);

			_data += string.Format("{0} {1} {2} {3}\n", _countStep, _monteCarlo.CountParticles, _monteCarlo.CountEjectedParticles, _monteCarlo.CountAbsorbedParticles);

			GC.Collect();
		}

		private void OnClickButtomSaveData(object sender, EventArgs e)
		{
			var saveDialog = new SaveFileDialog
			{
				Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
				RestoreDirectory = true
			};
			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				using var sw = new StreamWriter(saveDialog.OpenFile(), Encoding.Default);
				sw.Write(_data);
			}
		}

		private void OnValueChangedCountBoom(object sender, EventArgs e)
		{
			progressBar_statusReactor.Maximum = (int)nud_No.Value * (int)nud_countBoom.Value;
		}
	}
}