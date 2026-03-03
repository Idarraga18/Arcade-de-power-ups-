using UnityEngine;
using Unity.Hierarchy;
public class PlayerStats : MonoBehaviour
{
   public float vidaMaxima = 100f;
    public float vidaActual;
    public float velocudadBase = 5f;
    public float velocidadActual;
    public float chalecoActivo;

    void Start()
    {
        vidaActual = vidaMaxima;
        velocidadActual = velocudadBase;
        chalecoActivo = false;
    } 

    public void Vida(float cantidad)
    {
        vidaActual += cantidad;
        if (vidaActual > vidaMaxima)
        {
            vidaActual = vidaMaxima;
        }
    }   

    public void MultiplicarVelocidad(float multiplicado)
    {
        velocidadActual = velocudadBase * multiplicado; 
        
    }
    public void ColocarEscudo(float multiplicado)
    {
        chalecoActivo = true;
    }

    void Update()
    {
      
    }
}
