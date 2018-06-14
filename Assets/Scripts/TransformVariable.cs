using UnityEngine;

[CreateAssetMenu]
public class TransformVariable : ScriptableObject
{
	#if UNITY_EDITOR
	[Multiline]
	public string DeveloperDescription = "";
	#endif
	public Transform Value;

	public void SetValue(Transform value)
	{
		Value = value;
	}

	public void SetValue(TransformVariable value)
	{
		Value = value.Value;
	}
}
