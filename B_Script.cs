﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Script : MonoBehaviour
{

    public GameObject prefabObstacle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        Instantiate(prefabObstacle);
    }
}
