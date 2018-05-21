using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardListener : MonoBehaviour {

	public BoolVariable KeydownAlpha1;
	public BoolVariable KeydownAlpha2;
	public BoolVariable KeydownAplha3;

	void UpdateKeyboardInputs() 
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			KeydownAlpha1.SetValue(true);
			Debug.Log ("Alpha1 down.");
		} else {
			KeydownAlpha1.SetValue(false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			KeydownAlpha2.SetValue(true);
			Debug.Log ("Alpha2 down.");
		} else {
			KeydownAlpha2.SetValue(false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			KeydownAplha3.SetValue(true);
			Debug.Log ("Alpha3 down.");
		} else {
			KeydownAplha3.SetValue(false);
		}
	}
}
