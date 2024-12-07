using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuGameOver : MonoBehaviour
{
    public TMP_Text textPuntos; // Texto para mostrar los puntos (opcional, si es común a ambos paneles)
    public GameObject panelGanador; // Panel específico para el ganador
    public GameObject panelPerdedor; // Panel específico para el perdedor
    public GameObject botonAvanzarNivel; // Botón para avanzar al siguiente nivel
    public TMP_Text textoGanador; // Texto del panel de ganador
    public TMP_Text textoPerdedor; // Texto del panel de perdedor
    public AudioClip musicaTriunfo; // Música para el ganador
    public AudioClip musicaDerrota; // Música para el perdedor
    private AudioSource audioSource; // Reproductor de audio

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void MostrarGameOver()
    {
        Time.timeScale = 0; // Pausar el juego

        // Obtener los puntos desde el script Puntos
        int puntosJugador = FindObjectOfType<Puntos>().puntos;

        // Verificar si el jugador ganó o perdió
        if (puntosJugador > 16)
        {
            panelGanador.SetActive(true); // Mostrar panel del ganador
            textoGanador.text = $"¡Felicidades, has ganado!\nPuntos: {puntosJugador}"; // Mensaje con puntos
            audioSource.clip = musicaTriunfo; // Asignar música de triunfo
            audioSource.Play();
            botonAvanzarNivel.SetActive(true); // Activar el botón para avanzar de nivel
        }
        else
        {
            panelPerdedor.SetActive(true); // Mostrar panel del perdedor
            textoPerdedor.text = $"¡Intenta de nuevo, has perdido!\nPuntos: {puntosJugador}"; // Mensaje con puntos
            audioSource.clip = musicaDerrota; // Asignar música de derrota
            audioSource.Play();
            botonAvanzarNivel.SetActive(false); // Activar el botón para avanzar de nivel

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

    public void AvanzarNivel()
    {
        Time.timeScale = 1; // Reiniciar el tiempo
        SceneManager.LoadScene("SampleScene 2"); // Cargar la siguiente escena
    }
}





