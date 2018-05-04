using UnityEngine;
using System.Collections;
using UnityEditor;

public class PlatformerInput : MonoBehaviour
{

	Vector2 speed;
	public float walkSpeed = 4;
	public float jumpSpeed = 6;
	public float gravity = -9.8f;
	float ground;
	SpriteRenderer sr;
	public Sprite jump, stand, walk1, walk2;
	float walkTime = 0.1f;


	// Use this for initialization
	void Start ()
	{
		ground = transform.position.y;	
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.RightArrow)) {
			speed.x = walkSpeed;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			speed.x = -walkSpeed;
		} else {
			speed.x = 0;
		}

		if (transform.position.y == ground && Input.GetKey (KeyCode.Space)) {
			speed.y = jumpSpeed;
		}

		if (transform.position.y != ground) {
			speed.y = speed.y + gravity * Time.deltaTime;
		}

		if (ground > transform.position.y) {
			speed.y = 0;
			Vector3 position = transform.position;
			position.y = ground;
			transform.position = position;
		}

		transform.Translate (Time.deltaTime * speed.x, Time.deltaTime * speed.y, 0);

		if (speed.y != 0) {
			sr.sprite = jump;
		} else {
			if (speed.x != 0) {
				walkTime = walkTime - Time.deltaTime;
				if (walkTime <= 0) {
					if (sr.sprite == walk1) {
						sr.sprite = walk2;
					} else {
						sr.sprite = walk1;
					}
					walkTime = 0.1f;
				}
			} else {
				sr.sprite = stand;
			}
		}

		if (speed.x >= 0) {
			sr.flipX = false;
		} else {
			sr.flipX = true;
		}


	}
}
