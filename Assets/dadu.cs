using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadu : MonoBehaviour {

	public GameObject ObjekDadu;
	private int mulaiHitung;
	public int angkaDadu;
	public Vector3[] posisiDadu;
	public dadu2 d2;
	// Use this for initialization
	void Start () {
		mulaiHitung = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (mulaiHitung == 1) {
			ObjekDadu.transform.Rotate (50, 50, 50);
			d2.ObjekDadu2.transform.Rotate (50, 50, 50);
		}
	}
	void SetDaduPos(int value){
		Quaternion temp = ObjekDadu.transform.rotation;
		temp.eulerAngles = posisiDadu [value];
		ObjekDadu.transform.rotation = temp;

	}
	void SetDaduPos2(int value){
		Quaternion daduKedua = d2.ObjekDadu2.transform.rotation;
		daduKedua.eulerAngles = d2.posisiDadu2 [value];
		d2.ObjekDadu2.transform.rotation = daduKedua;
	}

	void OnGUI(){
		if(mulaiHitung == 0){
			if(GUI.Button(new Rect(10,10,100,30), "Kocok Dadu")){
				mulaiHitung = 1;
			}
		}
		if(mulaiHitung == 1){
			if (GUI.Button (new Rect (10, 10, 100, 30), "Lempar Dadu")) {
				angkaDadu = Random.Range (1, 7);
				d2.angkaDadu2 = Random.Range (1, 7);
				SetDaduPos (angkaDadu);
				SetDaduPos2 (d2.angkaDadu2);
				mulaiHitung = 0;
			}			
		}
	}
}
