using UnityEngine;
using System.Collections;

public class Object : MonoBehaviour {

	[SerializeField] private float objectSpeed = 1;
	[SerializeField] private float resetPosition = -21.65f;
	[SerializeField] private float startPosition = 79.67f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	protected virtual void Update () {

		if (!GameManager.instance.GameOver) {
			transform.Translate(Vector3.left * (objectSpeed * Time.deltaTime));

			if (transform.localPosition.x <= resetPosition) {
				Vector3 newPos = new Vector3(startPosition, transform.position.y, transform.position.z);
				transform.position = newPos;
			}
		}

	}
}
