﻿using UnityEngine;
using System.Collections;

public class DieDelay : MonoBehaviour {

    public float delay = 1.0f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, delay);
	}
}
