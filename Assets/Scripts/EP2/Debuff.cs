using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuff : PlayerMove
{
    public GameObject gun;

    private void Start()
    {
        gun.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            runSpeed = 1.5f;
            animator.SetBool("danger", true);
            gun.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            animator.SetBool("danger", false);
            runSpeed = 3;
            gun.SetActive(false);
        }
    }
}
