using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollider : MonoBehaviour {

    public float delay;

	// Use this for initialization
	void Start () {
        Invoke("Remove", delay);
	}
	
	// Update is called once per frame
	void Remove() {
        Destroy(gameObject);
	}
}
