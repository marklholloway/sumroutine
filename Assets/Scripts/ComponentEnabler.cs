using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentEnabler : MonoBehaviour {

	[SerializeField]
	Behaviour[] componentsToEnable;

	void Awake()
	{
		this.enabled = false;
	}
	void OnEnable()
	{
		EnableComponents ();
		this.enabled = false;
	}

	void EnableComponents ()
	{
		for (int i = 0; i < componentsToEnable.Length; i++) 
		{
			componentsToEnable [i].enabled = true;
		}
	}
}
