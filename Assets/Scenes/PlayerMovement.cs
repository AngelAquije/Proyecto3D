using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ProcessMovement() 
    {
        //Input del jugador (WASD)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Determinar si esta corriendo (Shift)
        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        //Establecemos la velocidad segun si esta corriendo o no
        //float speed = isRunning;
    }
}
