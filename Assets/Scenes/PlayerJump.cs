using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 7f; // Fuerza del salto
    public Transform groundCheck; // Objeto vacio que verifica si el jugador esta
    public LayerMask groundMask; // La capa que corresponde al suelo

    private Rigidbody rb;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        //Revisar si el jugador esta en el suelo
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.4f, groundMask); // Verificamos si hay un layer de suelo

        //Si el jugador esta en el suelo y presiona Espacio, salta
        if (isGrounded && Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Aplica una fuerza hacia arriba
        }
    }
}
