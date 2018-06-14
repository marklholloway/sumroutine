using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterSelectionManager : MonoBehaviour {

	public TransformVariable firstIndex;
	public TransformVariable secondIndex;
	public TransformVariable thirdIndex;
	public TransformVariable fourthIndex;

	public TransformReference firstIndexReference;
	public TransformReference secondIndexReference;
	public TransformReference thirdIndexReference;
	public TransformReference fourthIndexReference;

	public BoolReference alpha1;
	public BoolReference alpha2;
	public BoolReference alpha3;
	public BoolReference alpha4;

	private bool alpha1State;
	private bool alpha2State;
	private bool alpha3State;
	private bool alpha4State;

	public UnityEvent Index1add;
	public UnityEvent Index2add;
	public UnityEvent Index3add;
	public UnityEvent Index4add;

	void UpdateInputReferences()
	{
		alpha1State = alpha1.Value;
		alpha2State = alpha2.Value;
		alpha3State = alpha3.Value;
		alpha4State = alpha4.Value;
	}

	void ManualUpdate () 
	{

	} 

	public void Index1Assign (Transform newTransform)
	{
		firstIndex.SetValue (newTransform);
	}

	public void Index2Assign (Transform newTransform)
	{
		secondIndex.SetValue (newTransform);
	}

	public void Index3Assign (Transform newTransform)
	{
		thirdIndex.SetValue (newTransform);
	}

	public void Index4Assign (Transform newTransform)
	{
		fourthIndex.SetValue (newTransform);
	}

	public bool RequestAddNewCharacter (Transform transformToAdd)
	{

		if (firstIndexReference.Value == null) {
			Index1Assign (transformToAdd);
			Index1add.Invoke ();
			return true;
		} else if (secondIndexReference.Value == null) {
			Index2Assign (transformToAdd);
			Index2add.Invoke ();
			return true;
		} else if (thirdIndexReference.Value == null) {
			Index3Assign (transformToAdd);
			Index3add.Invoke ();
			return true;
		} else if (fourthIndexReference.Value == null) {
			Index4Assign (transformToAdd);
			Index4add.Invoke ();
			return true;
		} else 
		{
			return false;
		}
	}



	public void RemoveIndexOne()
	{
		Index1Assign (null);
	}

	public void RemoveIndexTwo()
	{
		Index2Assign (null);
	}

	public void RemoveIndexThree()
	{
		Index3Assign (null);
	}

	public void RemoveIndexFour()
	{
		Index4Assign (null);
	}

}
