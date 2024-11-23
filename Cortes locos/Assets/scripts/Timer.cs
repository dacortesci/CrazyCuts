using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer = 0;

    public Text textoTimer;
    public TextMeshProUGUI textoTimerPro;

    private bool isGameOver = false;  // Variable para verificar si el juego ha terminado

    // Referencia al AudioSource de la música de fondo
    public AudioSource backgroundMusic;

    void Start()
    {
        // Opcional: Asegurarse de que la música se reproduzca al inicio
        if (backgroundMusic != null)
        {
            backgroundMusic.Play();
        }
    }

    void Update()
    {
        if (!isGameOver)  // Solo actualizar el temporizador si el juego no ha terminado
        {
            timer -= Time.deltaTime;

            // Actualizar el texto del temporizador
            textoTimer.text = timer.ToString("f0");
            textoTimerPro.text = timer.ToString("f0");

            // Comprobar si el tiempo ha llegado a cero o menos
            if (timer <= 0)
            {
                timer = 0; // Asegurarse de que el temporizador no baje de cero
                isGameOver = true; // Marcar el juego como terminado
                EndGame(); // Llamar a la función para terminar el juego
            }
        }
    }

    void EndGame()
    {
        // Detener el tiempo
        Time.timeScale = 0;

        // Detener la música de fondo
        if (backgroundMusic != null)
        {
            backgroundMusic.Stop();
            Debug.Log("Música de fondo detenida.");
        }
        else
        {
            Debug.LogWarning("No se asignó el AudioSource de la música de fondo.");
        }

        // Mostrar el menú de Game Over
        FindObjectOfType<MenuGameOver>().MostrarGameOver();
    }
}