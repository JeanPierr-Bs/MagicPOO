using UnityEngine;

interface IAfectarVida
{
    void Curar(int Valor);
    void RecibirDanno(int Valor);
}

public abstract class Portador : IAfectarVida
{
    [Header("Portador")]
    [SerializeField]
    private string nombre;
    private Vida vida = new Vida(0, 100, 100);

    protected string Nombre { get => nombre; }
    //protected Estadistica Vida { get => vida; set => vida = value; }

    public Portador()
    {
    }

    public void Curar(int Valor)
    {
        vida 

        throw new System.NotImplementedException();
    }

    public void RecibirDanno(int Valor)
    {
        throw new System.NotImplementedException();
    }
}
