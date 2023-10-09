using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

internal abstract class Figura
{
  protected Color _color;

  public abstract double GetArea();
  protected Color color; // Atributo color

    // Constructor de Figura
    public Figura(Color color)
    {
        this.color = color;
    }

    
    

    // Método para mostrar información de la figura
    public override string ToString()
    {
        return $"Color: {color}";

    }
    
    }