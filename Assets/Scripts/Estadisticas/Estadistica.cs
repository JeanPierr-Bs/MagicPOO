using System.Drawing;
using UnityEngine;

public class Estadistica : MonoBehaviour
{
    private int valorMinimo;
    private int valorMaximo;
    private int valorActual;

    public int ValorMaximo { get => valorMaximo; set => valorMaximo = value; }
    public int ValorMinimo { get => valorMinimo; set => valorMinimo = value; }
    public int ValorActual { get => valorActual; set => valorActual = value; }

    public Estadistica(float minimo, float maximo, float actual)
    {
        ValorMinimo = (int)minimo;
        ValorMaximo = (int)maximo;
        ValorActual = (int)Mathf.Clamp(actual, minimo, maximo);
    }

    public void AfectarEstadisticas(int Valor)
    {        
        ValorActual = Mathf.Clamp(ValorActual + Valor, ValorMinimo, ValorMaximo);
    }
}
