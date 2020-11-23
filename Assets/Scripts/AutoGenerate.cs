using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGenerate : MonoBehaviour
{
    public PlayerCollision playerr;
    public PlayerMovement player;
    protected GameObject Object;
    public GameObject Objects;
    public GameObject[] Obstacles;
    protected float Time;
    public GetScore score;

    private enum Side
    {
        LEFT,
        MID,
        RIGHT
    }

    protected int RandomNumber()
    {
        int random = Random.Range(0, 2);
        return random;
    }

    private Side side;

    private Side RandomSize()
    {
        int random = Random.Range(0, 3);
        switch (random)
        {
            case 0: { side = Side.LEFT; break; }
            case 1: { side = Side.MID; break; }
            case 2: { side = Side.RIGHT; break; }
            default: { side = Side.MID; break; }
        }
        return side;
    }

    protected float SideSet()
    {
        float result = 0;
        side = RandomSize();
        switch (side)
        {
            case Side.LEFT: { result = 4f; break; }
            case Side.MID: { result = 0; break; }
            case Side.RIGHT: { result = -4f; break; }
        }
        return result;
    }

    public virtual void Start()
    {

    }
    public virtual void UpdateAfterTimeSet()
    {

    }
}
