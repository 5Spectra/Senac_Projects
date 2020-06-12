﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Transform player;

	public float zoomMinimo = 15f;
	public float zoomMaximo = 4f;
	public float intervalo = 0.1f;

	private Camera mCamera;
	private float velocidaZoom;
	private Vector3 velocidadeMovimento;

	void Start () {
		mCamera = GetComponent<Camera> ();
	}

	void Update () {
		
			if (player.position.y > 0) {
				mCamera.orthographicSize = Mathf.SmoothDamp (mCamera.orthographicSize, zoomMinimo, ref velocidaZoom, intervalo);
			} else {
				Vector3 novaPosicao = new Vector3 (player.position.x, player.position.y, - 10);
				transform.position = Vector3.SmoothDamp (transform.position, novaPosicao, ref velocidadeMovimento, intervalo);
				mCamera.orthographicSize = Mathf.SmoothDamp (mCamera.orthographicSize, zoomMaximo, ref velocidaZoom, intervalo);
			}
			
	}
}