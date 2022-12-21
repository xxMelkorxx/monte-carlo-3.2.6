using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace monte_carlo;

public class Drawing
{
    private Graphics _graphics;
    private readonly double _alpha, _beta;

    public Drawing(PictureBox pB, double x1, double y1, double x2, double y2)
    {
        var bitmap = new Bitmap(pB.Width, pB.Height);
        _graphics = Graphics.FromImage(bitmap);
        _graphics.SmoothingMode = SmoothingMode.AntiAlias;
        _graphics.TranslateTransform(pB.Width / 2, pB.Height / 2);
        Clear();
			
        // Вычисление коэффициентов преобразование.
        _alpha = pB.Width / (x2 - x1);
        _beta = -pB.Height / (y2 - y1);

        pB.Image = bitmap;
    }

    public void Clear()
    {
		_graphics.Clear(Color.White);
	}

    /// <summary>
    /// Преобразует мировые координаты в координаты окна (пиксели).
    /// </summary>
    /// <param name="x">X в мировых координатах.</param>
    /// <returns>Координата, преобразованная в координаты окна (пиксели).</returns>
    private float OutX(double x)
    {
        return (float)(x * _alpha);
    }

    /// <summary>
    /// Преобразует мировые координаты в координаты окна (пиксели).
    /// </summary>
    /// <param name="y">Y мировых координатах.s</param>
    /// <returns>Координата, преобразованная в координаты окна (пиксели).</returns>
    private float OutY(double y)
    {
        return (float)(y * _beta);
    }

    /// <summary>
    /// Рисует заполненный эллипс.
    /// </summary>
    /// <param name="color"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    private void DrawFillEllipse(Color color, double x, double y, double width, double height)
    {
        var brush = new SolidBrush(color);
        _graphics.FillEllipse(brush, OutX(x) - OutX(width) / 2, OutY(y) - OutY(height) / 2, OutX(width), OutY(height));
    }
    
    /// <summary>
    /// Рисует эллипс.
    /// </summary>
    /// <param name="color"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    private void DrawEllipse(Color color, double x, double y, double width, double height, float widthPen = 1f)
    {
        var pen = new Pen(color, widthPen);
        _graphics.DrawEllipse(pen, OutX(x) - OutX(width) / 2, OutY(y) - OutY(height) / 2, OutX(width), OutY(height));
    }
        
	public void DrawParticles(double radius, List<Vector2D> particles, int countBoom)
    {
        Color color;
        if (particles.Count < countBoom * 0.5)
            color = Color.Black;
        else if (particles.Count > countBoom * 0.8)
            color = Color.Red;
        else color = Color.Gold;

		DrawFillEllipse(Color.White, 0, 0, 2 * radius, 2 * radius);
		DrawEllipse(color, 0, 0, 2 * radius, 2 * radius, 2f);

		particles.ForEach(p => DrawFillEllipse(Color.Black, p.X, p.Y, radius * 0.02, radius * 0.02));
    }
}