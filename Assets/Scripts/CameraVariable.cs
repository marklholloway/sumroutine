using UnityEngine;

[CreateAssetMenu]
public class CameraVariable : ScriptableObject 
{

	#if UNITY_EDITOR
	[Multiline]
	public string DeveloperDescription = "";
	#endif
	public Camera Value;

	public void SetValue(Camera value)
	{
		Value = value;
	}

	public void SetValue(CameraVariable value)
	{
		Value = value.Value;
	}

}
