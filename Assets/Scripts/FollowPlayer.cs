using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private float DistanceZ;
    private float DistanceX;
    public GameObject Player;

    private void Start()
    {
        DistanceZ = Player.transform.position.z - transform.position.z;
        DistanceX = Player.transform.position.x - transform.position.x;
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(Player.transform.position.x - DistanceX,
                                        transform.position.y,
                                        Player.transform.position.z - DistanceZ);
    }
}
