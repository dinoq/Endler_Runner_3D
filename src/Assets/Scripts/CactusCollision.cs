using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusCollision : MonoBehaviour
{

    private GameSettings settings;

    private void Start()
    {
        settings = FindObjectOfType<GameSettings>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            settings.stopGame();
        }
    }
}
