using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorld : MonoBehaviour
{
    public GameSettings settings;

    public GameObject wallPrefab;
    public GameObject groundPrefab;

    private GameObject wallElement;
    private GameObject groundElement;
    private int length = 8;
    // Start is called before the first frame update
    void Start()
    {
        settings = GameObject.FindObjectOfType<GameSettings>();

        for (int i = 0; i < length; i++)
        {
            if(groundElement == null)
            {
                //wallElement = Instantiate(wallPrefab, new Vector3(0, 1.5f, -5), Quaternion.identity);
                groundElement = Instantiate(groundPrefab, new Vector3(0, 0, -5), Quaternion.identity);
            }
            else
            {
                //wallElement = Instantiate(wallPrefab, wallElement.transform.position + new Vector3(0, 0, 5), Quaternion.identity);
                groundElement = Instantiate(groundPrefab, groundElement.transform.position + new Vector3(0, 0, 5), Quaternion.identity);

            }

            //wallElement.transform.SetParent(transform.GetChild(0));
            groundElement.transform.SetParent(transform.GetChild(1));
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(groundElement != null && transform.childCount > 0 && transform.GetChild(0).transform.childCount < length)
        {
            //wallElement = Instantiate(wallPrefab, new Vector3(wallElement.transform.position.x, wallElement.transform.position.y, wallElement.transform.position.z + 5f - (settings.getSpeed() * Time.deltaTime)), Quaternion.identity);
            groundElement = Instantiate(groundPrefab, new Vector3(groundElement.transform.position.x, groundElement.transform.position.y, groundElement.transform.position.z + 5f - (settings.getSpeed() * Time.deltaTime)), Quaternion.identity);
            
            //wallElement.transform.SetParent(transform.GetChild(0));
            groundElement.transform.SetParent(transform.GetChild(1));
        }
    }
}
