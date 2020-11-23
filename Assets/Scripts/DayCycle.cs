using UnityEngine;

public class DayCycle : MonoBehaviour
{
    public GetScore Score;
    private float rotateSpeed;
    // Update is called once per frame
    void Update()
    {
        rotateSpeed = Score.GetMyScore() * Time.deltaTime;
        transform.Rotate(0.05f, Input.GetAxis("Horizontal") * rotateSpeed, 0);
    }
}
