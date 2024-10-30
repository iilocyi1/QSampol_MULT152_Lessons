using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENemy : MonoBehaviour
{
    Rigidbody enemyrb;
    GameObject player;
    public float speed = 90.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        enemyrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 seekDirection = player.transform.position - transform.position;
        enemyrb.AddForce((seekDirection).normalized * speed * Time.deltaTime);
    }
}
