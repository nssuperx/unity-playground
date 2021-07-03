using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EulerQuatVisualize : MonoBehaviour {
	[SerializeField,Range(-720f,720f)] private float eulerX,eulerY,eulerZ;
	[SerializeField] private Vector3 eulerVector;
	[SerializeField] private Quaternion quaternion;
	private GameObject cubeEulerX,cubeEulerY,cubeEulerZ;
	private GameObject cubeQuaternionX,cubeQuaternionY,cubeQuaternionZ,cubeQuaternionW;
	private Renderer[] renderers = new Renderer[7];
	private float[] floats = new float[7];
	void Start () {
		cubeEulerX = GameObject.Find("CubeEulerX");
		cubeEulerY = GameObject.Find("CubeEulerY");
		cubeEulerZ = GameObject.Find("CubeEulerZ");
		cubeQuaternionX = GameObject.Find("CubeQuaternionX");
		cubeQuaternionY = GameObject.Find("CubeQuaternionY");
		cubeQuaternionZ = GameObject.Find("CubeQuaternionZ");
		cubeQuaternionW = GameObject.Find("CubeQuaternionW");

		renderers[0] = cubeEulerX.GetComponent<Renderer>();
		renderers[1] = cubeEulerY.GetComponent<Renderer>();
		renderers[2] = cubeEulerZ.GetComponent<Renderer>();
		renderers[3] = cubeQuaternionX.GetComponent<Renderer>();
		renderers[4] = cubeQuaternionY.GetComponent<Renderer>();
		renderers[5] = cubeQuaternionZ.GetComponent<Renderer>();
		renderers[6] = cubeQuaternionW.GetComponent<Renderer>();

		Debug.Log(Quaternion.identity.ToString("f7"));
	}
	
	void Update () {
		eulerVector = new Vector3(eulerX,eulerY,eulerZ);
		quaternion.eulerAngles = eulerVector;

		floats[0] = eulerVector.x;
		floats[1] = eulerVector.y;
		floats[2] = eulerVector.z;
		floats[3] = quaternion.x;
		floats[4] = quaternion.y;
		floats[5] = quaternion.z;
		floats[6] = quaternion.w;

		for(int i=0;i<7;i++){
			if(floats[i]>=0f){
				renderers[i].material.color = Color.magenta;
			}else{
				renderers[i].material.color = Color.cyan;
			}
		}

		cubeEulerX.transform.localScale = new Vector3(1f,Math.Abs(eulerVector.x/90f),1f);
		cubeEulerY.transform.localScale = new Vector3(1f,Math.Abs(eulerVector.y/90f),1f);
		cubeEulerZ.transform.localScale = new Vector3(1f,Math.Abs(eulerVector.z/90f),1f);
		cubeQuaternionX.transform.localScale = new Vector3(1f,Math.Abs(quaternion.x*8f),1f);
		cubeQuaternionY.transform.localScale = new Vector3(1f,Math.Abs(quaternion.y*8f),1f);
		cubeQuaternionZ.transform.localScale = new Vector3(1f,Math.Abs(quaternion.z*8f),1f);
		cubeQuaternionW.transform.localScale = new Vector3(1f,Math.Abs(quaternion.w*8f),1f);
	}
}
