using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float levelDuration = 120f; // Duración del nivel en segundos
    public UnityEngine.UI.Text timerText; // Referencia al objeto de texto en la interfaz de usuario

    private float elapsedTime = 0f;
    private bool levelCompleted = false;

    private void Update()
    {
        if (!levelCompleted)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerUI();

            if (elapsedTime >= levelDuration)
            {
                levelCompleted = true;
                SceneManager.LoadScene("Nivel2");
            }
        }
    }

    private void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = "Tiempo: " + timeString;
    }
}
