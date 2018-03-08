using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efekKartu : MonoBehaviour {

	public GameObject humvee, mtvvr, tank, tiger;
	int humveePos, mtvvrPos, tankPos, tigerPos, counterPos, targetPos, indexKartu;
	bool humveeMove, mtvvrMove, tankMove, tigerMove, efek;
	public GameObject[] Path;
	public GameObject[] kartu;
	// Use this for initialization
	void Start () {
		efek = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void generateKartuRandom(){
		indexKartu = Random.Range (1, 35);
	}
}
