using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 
[Serializable]
public class CameraReference {
	public bool UseConstant = true;
	public Camera ConstantValue;
	public CameraVariable Variable;

	public CameraReference()
	{ }

	public CameraReference(Camera value)
	{
		UseConstant = true;
		ConstantValue = value;
	}

	public Camera Value
	{
		get { return UseConstant ? ConstantValue : Variable.Value; }
	}

	public static implicit operator Camera(CameraReference reference)
	{
		return reference.Value;
	}

}
