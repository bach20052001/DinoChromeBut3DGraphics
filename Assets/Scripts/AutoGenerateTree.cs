using UnityEngine;

public class AutoGenerateTree : AutoGenerate
{
    private float directionZ;
    private float directionY;
    private int LengthOfObstacles;
    public void SetTime(float Time)
    {
        this.Time = Time;
    }

    public override void Start()
    {
        Time = 1.5f;
        InvokeRepeating(nameof(UpdateAfterTimeSet), 0, Time);
    }

    public override void UpdateAfterTimeSet()
    {
        LengthOfObstacles = Objects.transform.childCount;
        
        Object = Obstacles[RandomNumber()];

        Vector3 position = Objects.transform.GetChild(LengthOfObstacles - 1).localPosition + new Vector3(0,0,50);

        //float side = SideSet();

        GameObject newObstacles = Instantiate(Object, position, Quaternion.identity);
        newObstacles.transform.parent = Objects.transform;
    }
}
