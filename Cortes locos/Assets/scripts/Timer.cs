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

        // Aquí podrías mostrar un mensaje de "Game Over" en pantalla
        Debug.Log("Game Over");

        // O podrías hacer otras acciones como cargar otra escena o mostrar un menú

        FindObjectOfType<MenuGameOver>().MostrarGameOver();
    }
}
