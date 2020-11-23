using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float _speed = 30f;
    public GetScore Score;
    private PlayerCollision pc;
    private bool isOnGround;
    private bool isGetLow;
    public bool isDead = false;

    public void SetDead(bool isDead) {
        this.isDead = isDead;
    }

    private void Start()
    {
        pc = GetComponent<PlayerCollision>();
        rb = GetComponent<Rigidbody>();
        _speed = 30f;
        isDead = false;
    }

    private void FixedUpdate()
    {
        if (!isDead)
        {
            _speed = 30f + Score.GetMyScore() * Time.deltaTime / 2;
            rb.AddForce(0, 0, _speed * Time.deltaTime, ForceMode.VelocityChange);
            isOnGround = pc.GetIsOnGround();

            if (!isOnGround)
            {
                rb.AddForce(0, -150f * Time.deltaTime, _speed * Time.deltaTime, ForceMode.VelocityChange);
            }



            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
            {
                isGetLow = false;
                if (isOnGround)
                {
                    GetComponent<Animation>().CrossFade("Jump");
                    rb.AddForce(0, 1750f * Time.deltaTime, _speed * Time.deltaTime / 2f, ForceMode.VelocityChange);
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                {
                    if (!isGetLow)
                    {
                        isGetLow = true;
                        GetComponent<Animation>().CrossFade("GetLow");
                        if (!isOnGround)
                        {
                            rb.AddForce(0, -1750f * Time.deltaTime, 0, ForceMode.VelocityChange);
                        }
                    }
                }
                else
                {
                    isGetLow = false;
                    GetComponent<Animation>().CrossFade("Run");
                    if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                    {
                        rb.AddForce(-_speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    }

                    else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                    {
                        rb.AddForce(_speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    }
                }
            }
        }
    }
}

