using UnityEngine;
using System.Collections;

public class MousePlayerControl : MonoBehaviour
{

	public float speed = 2;


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		float finalSpeed = 0;
		if (Input.GetMouseButton (0)) {
			finalSpeed = speed;
		}

		if (Input.GetMouseButton (1)) {
			finalSpeed = speed * 5;
		}

		float middle = Screen.width / 2;
		if (Input.mousePosition.x > middle) {
			transform.Translate (Time.deltaTime * finalSpeed, 0, 0);
		} else {
			transform.Translate (Time.deltaTime * -finalSpeed, 0, 0);
		}
	
	}
}
