using System.Drawing;
using UnityEngine;

public class Estadistica : MonoBehaviour
{
    public int ValorMaximo;
    public int ValorMinimo;
    public int ValorActual;

    public Estadistica(int minimo, int maximo, int actual)
    {
        ValorMinimo = minimo;
        ValorMaximo = maximo;
        ValorActual = Mathf.Clamp(actual, minimo, maximo);
    }

    public void AfectarEstadisticas(int Valor)
    {
        //Realizar cambios a la UI directamente
        
        ValorActual = Mathf.Clamp(ValorActual + Valor, ValorMinimo, ValorMaximo);
    }
}
