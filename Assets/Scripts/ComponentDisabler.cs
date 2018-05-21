using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentDisabler : MonoBehaviour {

	[SerializeField]
	Behaviour[] componentsToDisable;

	void Awake()
	{
		this.enabled = false;
	}
	void OnEnable()
	{
		DisableComponents ();
		this.enabled = false;
	}

	void DisableComponents ()
	{
		for (int i = 0; i < componentsToDisable.Length; i++) 
		{
			componentsToDisable [i].enabled = false;
		}
	}
}
