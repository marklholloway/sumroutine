using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInit : MonoBehaviour {

	public CameraVariable ClientMainPlayerCamera;
	[SerializeField]
	public Camera CameraForInitialPlayerMain;
	void Start () {
		ClientMainPlayerCamera.Value = CameraForInitialPlayerMain;
	}

}
