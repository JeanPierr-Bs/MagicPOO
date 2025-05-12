using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float velocidad = 20f;
    public float tiempoVida = 5f; // Duración antes de destruirse

    private Vector3 direccion;

    public void LanzarHacia(Vector3 destino)
    {
        direccion = (destino - transform.position).normalized;
        Destroy(gameObject, tiempoVida); // Destruir luego del tiempo definido
    }

    void Update()
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Debug.Log($"💥 Proyectil impactó con enemigo: {other.name}");
            Destroy(gameObject);
        }
    }
}
