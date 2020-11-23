using UnityEngine;
using System.Collections;

public class Play_animations : MonoBehaviour {
	private Rigidbody rb;
	private PlayerCollision pc;
	private bool isOnGround;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		pc = GetComponent<PlayerCollision>();
	}

	// Update is called once per frame
	void Update()
	{
		bool isJump = false;
		GetComponent<Animation>().CrossFade("Run");
		rb.AddForce(0, -50f * Time.deltaTime, 50f * Time.deltaTime, ForceMode.VelocityChange);
		if (Input.GetKey(KeyCode.A))
		{
			isJump = false;
			rb.AddForce(-25f * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey(KeyCode.D))
		{
			isJump = false;
			rb.AddForce(25f * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey(KeyCode.Space))
		{
			isJump = true;
			GetComponent<Animation>().CrossFade("Jump");
		}

		if (isJump)
		{
			rb.AddForce(0, 100f * Time.deltaTime, 0, ForceMode.VelocityChange);
		}
	}
}
