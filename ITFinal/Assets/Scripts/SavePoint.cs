using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameController.respawn = transform.position;
        gameController.enteredSavePoint = true;
        gameController.currentHealth = gameController.maxHealth;
    }
}
