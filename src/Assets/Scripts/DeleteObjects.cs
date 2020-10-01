using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObjects : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cactus"))
        {
            Destroy(other.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
