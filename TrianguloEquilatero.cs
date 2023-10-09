using System.Drawing;
using System.Dynamic;
using P2_2_Figuras;

namespace TrianguloEquilatero;

internal class TrianguloEquilatero : Figura
{
    private double longitudLado;

    public TrianguloEquilatero(Color color, double longitudLado) : base(color)
    {
        this.longitudLado = longitudLado;
    }

    public override double GetArea()
    {
        return (Math.Sqrt(3) / 4) * longitudLado * longitudLado;
    }

    public override string ToString()
    {
        return $"FIGURA TRIANGULO EQUILATERO\n- Lado: {longitudLado}\n- {base.ToString()}";
    }
}