using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efektombol : MonoBehaviour {
	float scaleX, scaleY;

	public Color tekan, lepas;

	// Use this for initialization
	void Start () {
		scaleX = transform.localScale.x;
		scaleY = transform.localScale.y;		
	}
	
	void OnMouseDown(){
		transform.localScale = new Vector2 (scaleX/1.1f, scaleY/1.1f);
		GetComponent<SpriteRenderer>().color = tekan;
	}

	void OnMouseUp(){
		transform.localScale = new Vector2 (scaleX, scaleY);
		GetComponent<SpriteRenderer>().color = lepas;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
