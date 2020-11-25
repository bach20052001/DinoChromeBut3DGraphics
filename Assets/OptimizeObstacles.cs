using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimizeObstacles : MonoBehaviour
{
    public GameObject Birds;
    public GameObject Trees;
    public GameObject Grounds;
    public PlayerMovement player;
    public AutoGenerateBird birds;
    public AutoGenerateTree trees;
    public AutoGenerateGround grounds;
    public GetScore Score;

    // Update is called once per frame
    private void Start()
    {
        InvokeRepeating(nameof(DestroyTreesByTime), 0, trees.GetTime());
        InvokeRepeating(nameof(DestroyBirdsByTime), 0, birds.GetTime());
    }
    private void DestroyTreesByTime()
    {
        for (int i = 0; i < Trees.transform.childCount; i++)
        {
            if (player.transform.position.z - Trees.transform.GetChild(i).position.z > 50f)
            {
                Destroy(Trees.transform.GetChild(i).gameObject);
                break;
            }
        }
    }
    private void DestroyBirdsByTime()
    {
        for (int i = 0; i < Birds.transform.childCount; i++)
        {
            if (player.transform.position.z - Birds.transform.GetChild(i).position.z > 50f)
            {
                Destroy(Birds.transform.GetChild(i).gameObject);
                break;
            }
        }
    }

    private void Update()
    {
        for (int i = 0; i < Grounds.transform.childCount; i++)
        {
            if (Score.GetMyScore() - Grounds.transform.GetChild(i).position.z > 1000f)
            {
                Destroy(Grounds.transform.GetChild(i).gameObject);
                break;
            }
        }
    }
}
