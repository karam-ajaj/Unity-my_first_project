using UnityEngine;
using System.Collections;

public class PlatformerCamera : MonoBehaviour
{

	public Transform Player;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		float deltaX = Player.position.x - transform.position.x;
		if (deltaX > 5) {
			float movement = deltaX - 5;
			transform.Translate (movement, 0, 0);
		} else if (deltaX < -5) {
			float movement = deltaX + 5;
			transform.Translate (movement, 0, 0);
		}
	
	}
}
