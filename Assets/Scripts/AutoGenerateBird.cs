using UnityEngine;

public class AutoGenerateBird : AutoGenerate
{
    private float directionZ;
    private float directionY;
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
        InvokeRepeating(nameof(UpdateAfterTimeSet), 0, Time);
    }

    public override void UpdateAfterTimeSet()
    {
        LengthOfObstacles = Objects.transform.childCount;

        Object = Obstacles[RandomNumber()];

        Vector3 position = Objects.transform.GetChild(LengthOfObstacles - 1).GetComponent<Fly>().GetInitialPosition() + new Vector3(0, 0, 50);

        //float side = SideSet();

        GameObject newObstacles = Instantiate(Object, position, Quaternion.identity);
        newObstacles.transform.parent = Objects.transform;
    }
}
