using UnityEngine;

public class Vida : Estadistica 
{
    int _valorMaximo;
    int _valorMinimo;
    int _valorActual;

    public Vida(int minimo, int maximo, int actual) : base(minimo, maximo, actual)
    {
        base.AfectarEstadisticas(valorActual);

        //Otra
    }
}
