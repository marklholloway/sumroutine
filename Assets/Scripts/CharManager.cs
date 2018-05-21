//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class CharManager : MonoBehaviour {
//
//	[SerializeField]
//	public Transform Character1;
//	[SerializeField]
//	public Transform Character2;
//	CharDisabler chardisable1;
//	CharDisabler chardisable2;
//	bool occupied = false;
//	[SerializeField]
//	CameraSlerp slerpcamera;
//
//	void Awake() {
//	chardisable1 = Character1.gameObject.GetComponent<CharDisabler>();
//	chardisable2 = Character2.gameObject.GetComponent<CharDisabler>();
//	slerpcamera = slerpcamera.gameObject.GetComponent<CameraSlerp>();
//	}
//
//	IEnumerator activate1()
//	{
//		bool shouldContinue = chardisable2.inputEnabled;
//
//		do 
//		{
//			yield return 0;
//		} while (shouldContinue == true);
//		slerpcamera .BeginCameraTrans(Character2.transform,Character1.transform);
//
//		do 
//		{
//			yield return 0;
//		} while (slerpcamera .busy == true);
//		Character1.gameObject.SendMessage("Activate");
//		occupied = false;
//	}
//
//
//	IEnumerator activate2()
//	{
//		bool shouldContinue = chardisable1.inputEnabled;
//
//		do 
//		{
//			yield return 0;
//		} while (shouldContinue == true);
//		Character2.gameObject.SendMessage("Activate");
//		occupied = false;
//	}
//
//
//	void Update () {
//
//		if(Input.GetKey(KeyCode.N)){
//			if (occupied == false) {
//				occupied = true;
//				Character2.gameObject.SendMessage ("Deactivate");
//				StartCoroutine (activate1 ());
//			}
//		}
//
//		if(Input.GetKey(KeyCode.B)){
//			if (occupied == false) {
//				occupied = true;
//				Character1.gameObject.SendMessage ("Deactivate");
//				StartCoroutine (activate2 ());
//			}
//		}
//
//	}
//}
