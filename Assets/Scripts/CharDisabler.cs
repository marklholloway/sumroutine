//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class CharDisabler : MonoBehaviour {
//
//	public bool inputEnabled = false;
//	[SerializeField]
//	Behaviour[] componentsToDisable;
////	Player thisplayer;
//
//
//	void Awake () {
//
////	thisplayer = gameObject.GetComponent<Player>();
//	}
//		
//	
//
//	// Update is called once per frame
//	void Update () {
//
//		if(inputEnabled == false){
//			DisableComponents ();
//		}
//
//		if(inputEnabled == true){
////			if (thisplayer.isDead)
//			{
//				return;
//			}
//			EnableComponents ();
//		}
//
//	}
//
//	void Activate(){
//		inputEnabled =true;
//	}
//
//	void Deactivate(){
//		inputEnabled =false;
//	}
//
//	void DisableComponents ()
//	{
//		for (int i = 0; i < componentsToDisable.Length; i++) 
//		{
//			componentsToDisable [i].enabled = false;
//		}
//	}
//
//	void EnableComponents ()
//	{
//		for (int i = 0; i < componentsToDisable.Length; i++) 
//		{
//			componentsToDisable [i].enabled = true;
//		}
//	}
//}
