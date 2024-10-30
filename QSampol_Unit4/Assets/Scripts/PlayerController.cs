using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rbPlayer;
    GameObject focalPoint;
    Renderer rendererPlayer;

    public float speed = 100.0f;
    public float powerUpSpeed = 10.0f;

    bool hasPowerup;
        //led before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        rendererPlayer = GetComponent<Renderer>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float magnitude = forwardInput * speed * Time.deltaTime;
        rbPlayer.AddForce(focalPoint.transform.forward * magnitude, ForceMode.Force);

        if (forwardInput > 0)
        {
            rendererPlayer.material.color = new Color(1.0f - forwardInput, 1.0f, 1.0f - forwardInput);
        }

        else
        {
            rendererPlayer.material.color = new Color(1.0f + forwardInput, 1.0f, 1.0f + forwardInput);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUP"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (hasPowerup && collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player has collided with " + collision.gameObject + "with powerup set to: " + hasPowerup);
            Rigidbody rbEnemy = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayDir = collision.gameObject.transform.position - transform.position;

            rbEnemy.AddForce(awayDir * powerUpSpeed, ForceMode.Impulse);
        }
                


     }
}
