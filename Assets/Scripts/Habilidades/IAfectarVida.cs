using UnityEngine;

public interface IAfectarVida
{
    void Curar(int cantidad);
    void RecibirDaño(int cantidad);
}