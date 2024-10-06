using UnityEngine;

public class CustomCutterControl : MonoBehaviour
{
    // Teclas configurables para cada dirección
    public KeyCode moveUpKey = KeyCode.W;      // Tecla para mover hacia arriba
    public KeyCode moveDownKey = KeyCode.S;    // Tecla para mover hacia abajo
    public KeyCode moveLeftKey = KeyCode.A;     // Tecla para mover hacia la izquierda
    public KeyCode moveRightKey = KeyCode.D;    // Tecla para mover hacia la derecha

    public float moveSpeed = 5f;  // Velocidad de movimiento

    void Update()
    {
        // Inicializar el movimiento
        Vector2 movement = Vector2.zero;

        // Verificar la tecla de arriba
        if (Input.GetKey(moveUpKey))
        {
            movement.y += 1; // Mover hacia arriba
        }

        // Verificar la tecla de abajo
        if (Input.GetKey(moveDownKey))
        {
            movement.y -= 1; // Mover hacia abajo
        }

        // Verificar la tecla de izquierda
        if (Input.GetKey(moveLeftKey))
        {
            movement.x -= 1; // Mover hacia la izquierda
        }

        // Verificar la tecla de derecha
        if (Input.GetKey(moveRightKey))
        {
            movement.x += 1; // Mover hacia la derecha
        }

        // Normalizar el vector de movimiento para evitar movimiento diagonal más rápido
        movement.Normalize();

        // Mover el objeto
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}




