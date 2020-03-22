using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Script : MonoBehaviour
{
    public Vector2 position;
    public GameObject prefabObstacle;
    // Start is called before the first frame update
    void Start()
    {
        int x = 5;
        int y = 3;
        position.x = x;
        position.y = y;
        SpawnObstacleIn(position);
    }
    void SpawnObstacleIn(Vector2 position)
    {
        Instantiate(prefabObstacle, position, Quaternion.identity);

    }

}
