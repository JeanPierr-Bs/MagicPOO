using UnityEngine;

public class Mana : Estadistica 
{
    int _valorMaximo;
    int _valorMinimo;
    int _valorActual;

    public Mana(int minimo, int maximo, int actual) : base(minimo, maximo, actual)
    {
        base.AfectarEstadisticas(valorActual);
    }
}
