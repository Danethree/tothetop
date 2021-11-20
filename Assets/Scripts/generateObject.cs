using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objects;
    public GameObject prefab;
    public Transform[] spawns;
    
    int rand;
    int randSpawn;

    private void Update()
    {
        GenerateObject();
    }

     void GenerateObject()
    {
       if(prefab==null)
        {
           
            randSpawn = Random.Range(0, 3);
            rand = Random.Range(0, 3);
            prefab = Instantiate(objects[rand], spawns[randSpawn].position, Quaternion.identity);
            
        }
    }

    
  
}
