using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalikKartu : MonoBehaviour {

	public int fps = 60;
	public float rotateDegreePerSecond = 180f;
	public bool isFaceUp = false;
	bool isAnimationProcessing = false;	
	float waitTime;
	const float FLIP_DEGREE_LIMIT = 180f;
	// Use this for initialization
	void Start () {
		waitTime = 1.0f / fps;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			StartCoroutine (flipUp ());
		}
	}

	void OnClick(){
		StartCoroutine (flipUp());
	}
	IEnumerator flipUp(){
		isAnimationProcessing = true;

		bool done = false;
		while (!done) {
			float degree = rotateDegreePerSecond * Time.deltaTime;
			if (isFaceUp) {
				degree = -degree;
			}
			transform.Rotate (new Vector3 (0, 0, degree));
			if (FLIP_DEGREE_LIMIT < transform.eulerAngles.z) {
				transform.Rotate(new Vector3(0, 0, -degree));
				done = true;
			}

			yield return new WaitForSeconds (waitTime);
		}
		isAnimationProcessing = false;
	}
}
