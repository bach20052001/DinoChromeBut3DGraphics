using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private float DistanceZ;
    private float DistanceX;
    public GameObject Player;

    public void Toggle()
    {
        GameObject View1 = transform.GetChild(0).gameObject;
        GameObject View2 = transform.GetChild(1).gameObject;
        View1.SetActive(!View1.activeSelf);
        View2.SetActive(!View2.activeSelf);
    }

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
