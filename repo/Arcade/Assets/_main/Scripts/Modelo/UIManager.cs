using UnityEngine;
using TMPro;
using UnityEditorInternal;



public class UIManager : MonoBehaviour
{
    public enum PowerUPType
    {
        Heal,
        SpeedBoost,
        Shield,
        DamageBoost

    }
    private PowerUPType seletedPowerUPType;

    [SerializeField]
    private TMP_Text messageText;

    [SerializeField]
    private TMP_InputField inputField;

    private PlayerStats playerStats;

    public void SeleccionVida()
    {
        SeleccionPowerUp(PowerUPType.Heal);
    }

    public void SeleccionVelocidad()
    {
        SeleccionPowerUp(PowerUPType.SpeedBoost);
    }

    public void SeleccionEscudo()
    {
        SeleccionPowerUp(PowerUPType.Shield);
    }

    public void SeleccionDaño()
    {
        SeleccionPowerUp(PowerUPType.DamageBoost);
    }

    private void SeleccionPowerUp(PowerUPType type)
    {
        seletedPowerUPType = type;
        messageText.text = "Seleccionado: " + type.ToString();

    }

    private bool ValidarReferencias()

    {
        if (playerStats == null)
        {
            messageText.text = "Error: playerStats no asignado.";
            return false;

        }
        if ( inputField == null)
        {
            messageText.text = "Error: Input no asignado";
            return false;
        }
        return true;
    }

    public void AplicarPowerUpSeleccionado()
    {
        if (!ValidarReferencias()) return;
        if (!TryReadValue(out float value)) return;
    }

    private bool TryReadValue(out float value)
    {
        value = 0f;

        if( string.IsNullOrWhiteSpace(inputField.text))
        {
            messageText.text = "Ingrese un valor.";
            return false;
        }

        if (!float.TryParse(inputField.text, out value))
        {
            messageText.text = "Valor no válido. Ingrese un número.";
            return false;
        }
        return true;
    }
}