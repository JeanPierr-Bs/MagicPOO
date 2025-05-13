using UnityEngine;

public class Mana : Estadistica
{
    public TipoCarga TipoCarga { get; set; }

    public Mana():base()
    {
        
    }

    public Mana(int valorMinimo, int valorMaximo, int valorActual, TipoCarga tipoCarga)
        : base(valorMinimo, valorMaximo, valorActual)
    {
        TipoCarga = tipoCarga;
    }

    public void ConsumirMana(int cantidad) => AfectarEstadisticas(-cantidad);
    public void RegenerarMana(int cantidad) => AfectarEstadisticas(cantidad);
}
