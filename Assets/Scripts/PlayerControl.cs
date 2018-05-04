using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{

	public float speed = 2;



	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		float finalSpeed = speed;


		if (Input.GetKey (KeyCode.LeftShift)) {
			finalSpeed = speed * 4;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Time.deltaTime * finalSpeed, 0, 0);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Time.deltaTime * -finalSpeed, 0, 0);
		}
	
	}
}
