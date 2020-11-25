using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimizeGround : MonoBehaviour
{
    public GameObject Ground;
    private float DistanceZ;
    public GameObject Player;

    private void Start()
    {
        DistanceZ = Player.transform.position.z - Ground.transform.position.z;
    }

    private void FixedUpdate()
    {
        Ground.transform.position = new Vector3(Ground.transform.position.x,
                                        Ground.transform.position.y,
                                        Player.transform.position.z - DistanceZ);
    }
}
