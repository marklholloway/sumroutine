//using UnityEngine;
//
//
//public class PlayerShoot : MonoBehaviour {
//
//	private const string PLAYER_TAG = "Player";
//
//	public PlayerWeapon weapon;
//
//	[SerializeField]
//	private Camera cam;
//
//	[SerializeField]
//	private LayerMask mask;
//
//	void Start () 
//	{
//		if (cam == null)
//		{
//			Debug.LogError("PlayerShoot: No camera referenced!");
//			this.enabled = false;
//		}
//	}
//
//	// Update is called once per frame
//	void Update () 
//	{
//		if (Input.GetButtonDown ("Fire1")) 
//		{
//			
//			Shoot ();
//		}
//	}
//
//
//	void Shoot ()
//	{
//		
//		RaycastHit hit;
//
//		if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100, mask) ) 
//		{
//			
//			if (hit.collider.tag == PLAYER_TAG) 
//			{
//				
//				PlayerShot(hit.collider.name, weapon.damage);
//			}
//		}
//	}
//
//
//	void PlayerShot (string _playerID, int _damage)
//	{
//		Debug.Log (_playerID + " has been shot.");
//
//		Player _player = GameManager.GetPlayer (_playerID);
//		_player.TakeDamage (_damage);
//	}
//
//}
