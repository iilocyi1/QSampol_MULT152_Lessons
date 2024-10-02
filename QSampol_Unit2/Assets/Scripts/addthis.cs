using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addthis : MonoBehaviour
{
    private float xBounds = 25.0f / 2.0f;
    private float zBounds = 20.0f / 2.0f;
    private float speed = 5.0f;
    void Update()
    {
        float horzInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        float horzTrans = speed * Time.deltaTime * horzInput;
        float vertTrans = speed * Time.deltaTime * vertInput;
        transform.Translate(new Vector3(horzTrans, 0, vertTrans));

        if (transform.position.x > xBounds)
        {
            transform.position = new Vector3(xBounds, transform.position.y,
                 transform.position.z);
        }
        if (transform.position.x < -xBounds)
        {
            transform.position = new Vector3(-xBounds, transform.position.y,
                 transform.position.z);
        }

        if (transform.position.z > zBounds)
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y, zBounds);
        }
        if (transform.position.z < -zBounds)
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y, -zBounds);
        }
    }

}

