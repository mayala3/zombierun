using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowZombie : MonoBehaviour {

    // References the player
    public Transform player;

    public Vector3 offset;

    public float rspeed = 3.0f;
    public float fspeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position + offset), rspeed * Time.deltaTime);
        transform.position += transform.forward * fspeed * Time.deltaTime;
    }
}
