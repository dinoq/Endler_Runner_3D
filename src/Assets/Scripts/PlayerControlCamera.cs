using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlCamera : MonoBehaviour
{

    public Transform cameraTransform;
    public float followSpeed;
    private Vector3 desiredPosition;
    // Start is called before the first frame update
    void Start()
    {
        desiredPosition = cameraTransform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //desiredPosition = cameraTransform.position;
        //desiredPosition.y = transform.position.y+1.5f;
        //cameraTransform.position = Vector3.Lerp(cameraTransform.position, desiredPosition, Time.deltaTime * followSpeed);
    }
}
