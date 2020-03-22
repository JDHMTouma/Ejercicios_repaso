using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D_Script : MonoBehaviour
{
    public GameObject prefabObstacle;
    public int var;
    // Start is called before the first frame update
    void Start()
    {
        SpawnNObstacles(5);
    }
    void SpawnNObstacles(int var)
    {
        for (int i = 0; i < var; i++)
        {
            Instantiate(prefabObstacle);
        }
    }
}
