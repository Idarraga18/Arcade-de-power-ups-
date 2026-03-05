using UnityEngine;


public class PlayerStats : MonoBehaviour
{
    public float vidaMaxima = 100f;
    public float vidaActual;
    public float velocidadBase = 5f;
    public float velocidadActual;
    public bool chalecoActivo;
    void Start()
    {
        vidaActual = vidaMaxima;
        velocidadActual = velocidadBase;
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
        velocidadActual = velocidadBase * multiplicado;
    }
    public void ColocarEscudo(float multiplicado)
    {
        chalecoActivo = true;
    }

    public void CausarDaño(float CantidadDaño)
    {
        if (chalecoActivo)
        {
            return;
        }
        vidaActual -= CantidadDaño;
        if (vidaActual < 0)
       
            vidaActual = 0;
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
