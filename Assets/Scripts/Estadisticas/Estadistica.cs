using System.Drawing;
using UnityEngine;

public class Estadistica : MonoBehaviour
{
    [Header("Estadisticas")]
    [SerializeField]
    public int valorMaximo;
    [SerializeField]
    public int valorMinimo;
    [SerializeField]
    public int valorActual;

    public Estadistica(int minimo, int maximo, int actual)
    {
        valorMinimo = minimo;
        valorMaximo = maximo;
        valorActual = Mathf.Clamp(actual, minimo, maximo);
    }

    public void AfectarEstadisticas(int Valor)
    {
        //Realizar cambios a la UI directamente
        
        valorActual = Mathf.Clamp(valorActual + Valor, valorMinimo, valorMaximo);
    }
}
