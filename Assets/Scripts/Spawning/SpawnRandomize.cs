using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomize : MonoBehaviour
{
    Vector3[] spawns = new Vector3[3];

    // Start is called before the first frame update
    void Start()
    {
        //initialize possibel random spawns
        spawns[0] = new Vector3(844.2897f, 38.089f, 889.321f);
        spawns[1] = new Vector3(826.88f, 36.92041f, 864.85f);
        spawns[2] = new Vector3(864.2f, 36.92041f, 876.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Sets a random transform for the spawn parent
    public Transform setRandomTransform()
    {
       transform.position = spawns[Random.Range(0, spawns.Length)];

        return transform;
    }
}
