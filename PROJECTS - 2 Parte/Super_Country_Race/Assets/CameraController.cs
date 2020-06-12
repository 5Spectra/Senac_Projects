﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float m_DampTime = 0.1f, m_ScreenEdgeBuffer = 8f, m_MinSize = 6.5f;

	GameObject[] m_Targets;

	Camera m_Camera;
	float m_ZoomSpeed;
	Vector3 m_MoveVelocity, m_DesiredPosition;

	void Awake () {
		m_Camera = GetComponentInChildren<Camera> ();
		m_Targets = GameObject.FindGameObjectsWithTag ("Player");
	}

	void FixedUpdate () {
		Move ();
		Zoom ();
	}

	void Move(){
		FindAveragePosition ();
		transform.position = Vector3.SmoothDamp (transform.position, m_DesiredPosition, ref m_MoveVelocity, m_DampTime);
	}

	void FindAveragePosition(){
		Vector3 averagePos = new Vector3 ();
		int numTargets = 0;
	
		for (int i = 0; i < m_Targets.Length; i++) {
			if (!m_Targets [i].gameObject.activeSelf)
				continue;
		
			averagePos += m_Targets [i].transform.position;
			numTargets++;
		}

		if (numTargets > 0)
			averagePos /= numTargets;

		averagePos.y = transform.position.y;
		m_DesiredPosition = averagePos;
	}

	void Zoom(){
		float requiredSize = FindRequiredSize ();
		m_Camera.orthographicSize = Mathf.SmoothDamp (m_Camera.orthographicSize, requiredSize, ref m_ZoomSpeed, m_DampTime);
	
	}

	float FindRequiredSize(){
		Vector3 desiredLocalPos = transform.InverseTransformPoint (m_DesiredPosition);
		float size = 0f;

		for (int i = 0; i < m_Targets.Length; i++) {
			if (!m_Targets [i].gameObject.activeSelf)
				continue;

		Vector3 targetLocalPos = transform.InverseTransformPoint (m_Targets[i].transform.position);
			Vector3 desiredPosToTarget = targetLocalPos - desiredLocalPos;
			//size = Mathf.Max (size, Mathf.Abs (desiredPosToTarget.y));
			//size = Mathf.Max (size, Mathf.Abs (desiredPosToTarget.x) / m_Camera.aspect);
			size = Mathf.Max (Mathf.Max (size, Mathf.Abs (desiredPosToTarget.y)), Mathf.Abs (desiredPosToTarget.x) / m_Camera.aspect);
	}

		size += m_ScreenEdgeBuffer;
		size = Mathf.Max (size, m_MinSize);
		return size;
}

	public void SetStartPositionAndSize(){
		FindAveragePosition ();
		transform.position = m_DesiredPosition;
		m_Camera.orthographicSize = FindRequiredSize ();	
	}
}