using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRotation : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

		transform.Rotate (new Vector3 (10, 15, 35) * Time.deltaTime);

	}
}
