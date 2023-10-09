using System.Drawing;
using System.Dynamic;
using P2_2_Figuras;

namespace Circulo;

internal class Circulo : Figura
{
    private double radio;

    public Circulo(Color color, double radio) : base(color)
    {
        this.radio = radio;
    }

    public override double GetArea()
    {
        return Math.PI * radio * radio;
    }

    public override string ToString()
    {
        return $"FIGURA CIRCULO\n- Radio: {radio}\n- {base.ToString()}";
    }
}