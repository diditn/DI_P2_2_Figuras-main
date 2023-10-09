using System.Drawing;
using System.Dynamic;
using P2_2_Figuras;

namespace Rectangulo;

internal class Rectangulo : Figura
{
    private double baseRectangulo;
    private double alturaRectangulo;

    public Rectangulo(Color color, double baseRectangulo, double alturaRectangulo) : base(color)
    {
        this.baseRectangulo = baseRectangulo;
        this.alturaRectangulo = alturaRectangulo;
    }

    public override double GetArea()
    {
        return baseRectangulo * alturaRectangulo;
    }

    public override string ToString()
    {
        return $"FIGURA RECTANGULO\n- Alto: {alturaRectangulo}\n- Ancho: {baseRectangulo}\n- {base.ToString()}";
    }
}
