
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public PlayerMovement Player;
    private Rigidbody rb;
    public GameObject Birds;
    public GameObject Trees;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.touchCount == 1)
        {
            GetComponent<Animation>().CrossFade("Jump");
            rb.AddForce(0, 1000f * Time.deltaTime, 0, ForceMode.VelocityChange);
            this.enabled = false;
            Player.enabled = true;
            Birds.SetActive(true);
            Trees.SetActive(true);
        }   
    }
}
