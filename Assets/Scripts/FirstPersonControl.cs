using UnityEngine;
using System.Collections;

public class FirstPersonControl : MonoBehaviour
{

	public float mouseLookSpeed = 25;

	public Transform cam;

	public float horizontalAngel = 0;



	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		float x = Input.GetAxis ("Mouse X") * mouseLookSpeed;
		float y = Input.GetAxis ("Mouse Y") * -mouseLookSpeed;

		transform.Rotate (0, x, 0);

		if (y < 0 && horizontalAngel > -60) {
			cam.Rotate (y, 0, 0);
			horizontalAngel = horizontalAngel + y;
		} else if (y > 0 && horizontalAngel < 60) {
			cam.Rotate (y, 0, 0);
			horizontalAngel = horizontalAngel + y;
		}
			

	
	}
}
