using UnityEngine;

public class AutoGenerateGround : AutoGenerate
{
    private int LengthOfObstacles;
    public void SetTime(float Time)
    {
        this.Time = Time;
    }

    public float GetTime()
    {
        return Time;
    }

    public override void Start()
    {
        Time = 10f;
        InvokeRepeating(nameof(UpdateAfterTimeSet), 0, Time);
    }

    public override void UpdateAfterTimeSet()
    {
        LengthOfObstacles = Objects.transform.childCount;

        Object = Obstacles[0];

        Vector3 position = Objects.transform.GetChild(LengthOfObstacles - 1).localPosition + new Vector3(0, 0, 1000);

        GameObject newObstacles = Instantiate(Object, position, Quaternion.Euler(0,-90,0));
        newObstacles.transform.parent = Objects.transform;
    }
}
