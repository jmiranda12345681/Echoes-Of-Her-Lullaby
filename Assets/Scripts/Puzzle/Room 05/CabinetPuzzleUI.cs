using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CabinetPuzzleUI : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_InputField codeInputField;
    public TextMeshProUGUI feedbackText;
    public GameObject unlockVisualEffect;

    [Header("Settings")]
    public float unlockVisualDuration = 1.5f;

    private void Start()
    {
        if (feedbackText != null)
        {
            feedbackText.text = "";
        }

        if (unlockVisualEffect != null)
        {
            unlockVisualEffect.SetActive(false);
        }
    }

    /// <summary>
    /// Gets the code entered by the player
    /// </summary>
    public string GetEnteredCode()
    {
        if (codeInputField != null)
        {
            return codeInputField.text;
        }
        return "";
    }

    /// <summary>
    /// Shows visual feedback when the cabinet is unlocked
    /// </summary>
    public void ShowUnlockVisual()
    {
        if (feedbackText != null)
        {
            feedbackText.text = "UNLOCKED!";
            feedbackText.color = Color.green;
        }

        if (unlockVisualEffect != null)
        {
            unlockVisualEffect.SetActive(true);
        }
    }

    /// <summary>
    /// Clears the input field
    /// </summary>
    public void ClearInput()
    {
        if (codeInputField != null)
        {
            codeInputField.text = "";
        }

        if (feedbackText != null)
        {
            feedbackText.text = "";
        }
    }

    /// <summary>
    /// Shows error feedback
    /// </summary>
    public void ShowError(string message = "Wrong Code")
    {
        if (feedbackText != null)
        {
            feedbackText.text = message;
            feedbackText.color = Color.red;
        }
    }
}
