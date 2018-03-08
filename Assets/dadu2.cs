using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadu2 : MonoBehaviour {

	public GameObject ObjekDadu2;
	private int mulaiHitung;
	public int angkaDadu2;
	public Vector3[] posisiDadu2;
	// Use this for initialization
	void Start () {
		mulaiHitung = 0;
	}

	// Update is called once per frame
	void Update () {
		if (mulaiHitung == 1) {
			ObjekDadu2.transform.Rotate (50, 50, 50);
		}
	}
	void SetDaduPos2(int value){
		Quaternion temp = ObjekDadu2.transform.rotation;
		temp.eulerAngles = posisiDadu2 [value];
		ObjekDadu2.transform.rotation = temp;
	}
	/*void OnGUI(){
		if(mulaiHitung == 0){
			if(GUI.Button(new Rect(10,10,100,30), "Kocok Dadu")){
				mulaiHitung = 1;
			}
		}
		if(mulaiHitung == 1){
			if (GUI.Button (new Rect (10, 10, 100, 30), "Lempar Dadu")) {
				angkaDadu2 = Random.Range (1, 7);
				SetDaduPos2 (angkaDadu2);
				mulaiHitung = 0;
			}			
		}
	}*/
}
