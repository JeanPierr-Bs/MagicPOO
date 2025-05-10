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

    public Estadistica(int minimo, int maximo, int actual)
    {
        ValorMinimo = minimo;
        ValorMaximo = maximo;
        ValorActual = Mathf.Clamp(actual, minimo, maximo);
    }

    public void AfectarEstadisticas(int Valor)
    {        
        ValorActual = Mathf.Clamp(ValorActual + Valor, ValorMinimo, ValorMaximo);
        
        //Realizar cambios a la UI directamente

    }
}
