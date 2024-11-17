using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuGameOver : MonoBehaviour
{
    public TMP_Text textPuntos;
    public TMP_Text textResultado; // Texto para mostrar "Ganador" o "Perdedor"
    public GameObject gameOverPanel; 

    public void MostrarGameOver()
    {
        Time.timeScale = 0;  // Pausar el juego
        gameOverPanel.SetActive(true);  // Mostrar el panel de Game Over

        // Obtener los puntos desde el script Puntos
        int puntosJugador = FindObjectOfType<Puntos>().puntos;

        // Mostrar los puntos
        textPuntos.text = "Puntos: " + puntosJugador.ToString();

        // Mostrar mensaje de "Ganador" o "Perdedor" dependiendo de los puntos
        if (puntosJugador > 16)
        {
            textResultado.text = "¡Ganador!";  // Mostrar mensaje de Ganador
        }
        else
        {
            textResultado.text = "¡Perdedor!";  // Mostrar mensaje de Perdedor
        }
    }

    public void Reiniciar()
    {
        Time.timeScale = 1;  // Reiniciar el tiempo
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  // Recargar la escena actual
    }

    public void MenuInicial()
    {
        Time.timeScale = 1;  // Reiniciar el tiempo
        SceneManager.LoadScene("MenuInicial");  // Cargar el menú inicial
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;  // Detener la ejecución en el editor de Unity
        Application.Quit();  // Salir de la aplicación
    }
}



