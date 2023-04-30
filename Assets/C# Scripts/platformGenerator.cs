using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class platformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    

    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();

        

        for (int i = 0; i < 10; i++)
        {
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);
            SpawnerPosition.y += Random.Range(1f, 3f);
            
            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);

        }
    }

    

    void Update()
    {
       
        
    }
}
