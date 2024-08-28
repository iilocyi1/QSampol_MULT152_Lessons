using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //rate of speed, turn speed does not correspond with value
    private float speed = 15.0f;
    private float turnSpeed = 1.0f;

    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Debug.Log(Time.deltaTime);
        //Vector3.forward -- > (0,0,1)
        // (0,0,1) * Time.deltaTime = (0, 0, .004)

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //removed Time.deltaTime from rotate to speed up turn
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput);
     }
}
