using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Player;
    private bool isOnGround = true;
    public GameManager Manager;
    public GameObject Ground;

    public bool GetIsOnGround()
    {
        return isOnGround;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            gameObject.GetComponent<PlayerMovement>().SetDead(true);
            gameObject.GetComponent<Animation>().CrossFade("Death");
            Manager.GameOver();
        }
        isOnGround = false;
        if (collision.collider.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }

    private void Update()
    {
        if (Ground.transform.position.y - Player.transform.position.y > 5f)
        {
            Manager.GameOver();
        }
    }
}
