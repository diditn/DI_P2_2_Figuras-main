//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
List<Figura> figuras = new List<Figura>();

        figuras.Add(new Rectangulo(Color.FromArgb(255, 50, 20, 34), 3.9, 3));
        figuras.Add(new Circulo(Color.FromArgb(255, 30, 60, 90), 5));
        figuras.Add(new TrianguloEquilatero(Color.FromArgb(255, 10, 70, 120), 4));

        foreach (Figura figura in figuras)
        {
            Console.WriteLine(figura.ToString());
            Console.WriteLine($"- Área: {figura.GetArea()}\n");
        }
  }

}