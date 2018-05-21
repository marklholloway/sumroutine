using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public CameraReference cameraToUse;
	public Camera CameraBeingSynced;

	void OnEnable () 
	{
		CameraBeingSynced = cameraToUse.Value;
	}

	void UpdateCameraReference ()
	{
		CameraBeingSynced = cameraToUse.Value;
	}

	void Sync () 
	{
		CameraBeingSynced.transform.position = cameraToUse.Value.transform.position;
		CameraBeingSynced.transform.rotation = cameraToUse.Value.transform.rotation;
	}
}
