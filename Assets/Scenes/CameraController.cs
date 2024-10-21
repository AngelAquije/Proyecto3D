using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerBody; // Referencia al cuerpo del jugador para rotarlo
    public float mouseSensitivity = 100f; // Sensibilidad del mouse

    private float xRotation = 0f; // Control de la rotacion vertical

    // Start is called before the first frame update
    void Start()
    {
        //Bloqueamos el cursor en el centro de la pantalla
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Obtener el movimiento del mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; // Movimiento Horizontal del mouse
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; // Movimiento Vertical del mouse

        // Control de la rotacion vertical (evitamos que la camara rote mas de 90 grados hacia arriba o abajo)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //Limitar la rotacion para que no pase de 90 grados

        // Rotamos la camara en el eje x (arriba - abajo)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotamos el cuerpo del jugador en el eje Y (izquierda - derecha)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
