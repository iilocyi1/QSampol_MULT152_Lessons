using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalPrefabIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(animalPrefabs[animalPrefabIndex], new Vector3(2, 0, 21), animalPrefabs[animalPrefabIndex].transform.rotation);
        }
        
    }
}
