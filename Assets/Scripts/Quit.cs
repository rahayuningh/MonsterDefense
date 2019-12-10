using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	public void Doquit(){
		UnityEngine.Debug.LogError("Quit Game");
		Application.Quit();
	}

}
