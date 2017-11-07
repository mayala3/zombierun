using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // References the player
    public Transform player;

    // Distance behind the player
    public Vector3 offset;

	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z + offset.z);
	}
}
