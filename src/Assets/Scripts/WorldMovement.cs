using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMovement : MonoBehaviour
{

    public GameSettings settings;

    // Start is called before the first frame update
    void Start()
    {
        settings = GameObject.FindObjectOfType<GameSettings>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (settings.getSpeed() * Time.deltaTime));
    }
}
