using UnityEngine;

public class Fly : MonoBehaviour
{
    private float _speed = 0.1f;
    private Vector3 InitialPosition;

    public Vector3 GetInitialPosition()
    {
        return InitialPosition;
    }

    private void Start()
    {
        _speed = 0.1f;
        InitialPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - _speed); 
    }
}
