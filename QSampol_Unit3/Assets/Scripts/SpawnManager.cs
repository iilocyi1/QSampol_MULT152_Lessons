using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obPrefab;
    private Vector3 spawnPos = new Vector3(30, 0, 0);
    private PlayerController playerCtrl;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Spawnob", 2.5f, 2.5f);
        playerCtrl = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void Spawnob()
    {
        if (!playerCtrl.gameOver)
        {
            Instantiate(obPrefab, spawnPos, obPrefab.transform.rotation);
        }
    }
}
