using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCactus : MonoBehaviour
{

    public GameObject cactus;
    private float nextTimeSpawn = 0;
    // Start is called before the first frame update
    void Start()
    {
        nextTimeSpawn = Time.time + Random.Range(1, 3);
        //Debug.Log("SpawnCactus: nextTimeSpawn=" + nextTimeSpawn);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (nextTimeSpawn <= Time.time)
        {
            Instantiate(cactus, new Vector3((float)(transform.position.x), 0.5f, (float) (transform.position.z)), Quaternion.identity);
            if(Random.Range(0f,1f) > 0.5)
            {
                Instantiate(cactus, new Vector3((float)(transform.position.x), 0.5f, (float)(transform.position.z) + 0.5f), Quaternion.identity);

            }
            nextTimeSpawn = Time.time + Random.Range(1, 3);
        }
    }
}
