using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSlerp: MonoBehaviour {

	public Transform startPos;
	public Transform endPos;
	public float journeyTime = 1.0f;
	public float speed;
	public bool repeatable;
	public Transform midpoint;
	public Transform lookEndPos;
	public Transform lookStartPos;
	public Transform looktarget;
	public Transform slerpcamera;
	public float smoothSpeed = 0.125f;
	public float lookdownamount;
	public bool busy = false;


	float midpointdistance;
	float startTime;
	Vector3 centerPoint;
	Vector3 startRelCenter;
	Vector3 endRelCenter;	
	public Transform maincamera;

	void Awake()
	{
		slerpcamera = this.transform;

	}

	// Update is called once per frame
	void Update () 
	{

		GetCenter(Vector3.up);



	}

	IEnumerator cameratrans(Transform startposition,Transform endpoint)
	{
		float fracComplete = (Time.time - startTime) / journeyTime * speed;
		do {
			transform.position = Vector3.Slerp (startRelCenter, endRelCenter, fracComplete * speed);
			transform.position += centerPoint;

			maincamera.position = slerpcamera.position;
			maincamera.rotation = Quaternion.Lerp (startposition.rotation, endpoint.rotation, fracComplete * speed);

			if (fracComplete < .5f) {
				lookdownamount = (2 * fracComplete) * 30f;
			}

			if (fracComplete >= .5f) {
				lookdownamount = (1 - ((fracComplete - .5f) * 2)) * 30f;
			}


			maincamera.rotation *= Quaternion.Euler (lookdownamount, 0, 0);
		} while (fracComplete >= 1);

			if(fracComplete >=1)
		{
			busy = false;
			yield return null;
		}
	}

	public void BeginCameraTrans(Transform startposition,Transform endpoint)
	{
		busy = true;
		StartCoroutine (cameratrans(startposition,endpoint));
	}

	void Bounce()
	{
		if(!repeatable) 
		{
			float fracComplete = (Time.time - startTime) / journeyTime * speed;
			transform.position = Vector3.Slerp(startRelCenter, endRelCenter, fracComplete * speed);
			transform.position += centerPoint;

			maincamera.position = slerpcamera.position;
			maincamera.rotation = Quaternion.Lerp (startPos.rotation, endPos.rotation, fracComplete * speed);

			if (fracComplete < .5f) 
			{
				lookdownamount = (2 * fracComplete) * 30f;
			}

			if (fracComplete >= .5f) 
			{
				lookdownamount = (1 - ((fracComplete -.5f)*2)) * 30f;
			}


			maincamera.rotation *= Quaternion.Euler (lookdownamount, 0, 0);

		}

		if (repeatable) 
		{
			float fracComplete = Mathf.PingPong(Time.time - startTime, journeyTime / speed);
			transform.position = Vector3.Slerp(startRelCenter, endRelCenter, fracComplete * speed);
			transform.position += centerPoint;

			if (fracComplete >= 1) 
			{
				startTime = Time.time;
			}


			//			midpoint.position = (startPos.position + endPos.position)/2;
			//			midpointdistance = Vector3.Distance (startPos.position, midpoint.position);
			//			lookEndPos.position = endPos.position + (endPos.forward*midpointdistance) ;
			//			lookStartPos.position = startPos.position + (startPos.forward*midpointdistance);

			maincamera.position = slerpcamera.position;
			maincamera.rotation = Quaternion.Lerp (startPos.rotation, endPos.rotation, fracComplete * speed);

			if (fracComplete < .5f) 
			{
				lookdownamount = (2 * fracComplete) * 30f;
			}

			if (fracComplete >= .5f) 
			{
				lookdownamount = (1 - ((fracComplete -.5f)*2)) * 30f;
			}


			maincamera.rotation *= Quaternion.Euler (lookdownamount, 0, 0);
			//			if (fracComplete < .48f) 
			//			{
			//				looktarget.position = Vector3.Lerp(lookStartPos.position, midpoint.position, fracComplete * 2);
			//			}
			//
			//			if (fracComplete >= .52f) 
			//			{
			//				looktarget.position = Vector3.Lerp(midpoint.position, lookEndPos.position, ((fracComplete - .5f) * 2));
			//			}

			//
			//			Quaternion desiredrotation = slerpcamera.rotation;
			//			Quaternion smoothedRotation = Quaternion.Lerp (maincamera.rotation, desiredrotation, smoothSpeed);
			//			maincamera.rotation = smoothedRotation;
			//
			//			Vector3 desiredposition = slerpcamera.position;
			//			Vector3  smoothedPosition = Vector3 .Lerp (maincamera.position, desiredposition, smoothSpeed);
			//			maincamera.position = smoothedPosition;
			//
			// lerp rotation based on fracComplete

		}



	}

	public void GetCenter(Vector3 direction) {
		centerPoint = (startPos.position + endPos.position) * .5f;
		centerPoint -= direction;
		startRelCenter = startPos.position - centerPoint;
		endRelCenter = endPos.position - centerPoint;
	}
}