using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float Speed;

	// Use this for initialization
	void Start () {

		rb = gameObject.GetComponent<Rigidbody>();
		
	}

	void FixedUpdate ()
	{

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 Movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(Movement * Speed);

	}

	void OnTriggerEnter (Collider Other)
	{

		if (Other.gameObject.CompareTag("Pick Up"))
		{

			Other.gameObject.SetActive (false);

		}

	}
	

}
