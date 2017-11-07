using UnityEngine;

public class FollowPlayerAll : MonoBehaviour {

    // References the player
    public Transform player;

    // Distance behind the player
    public Vector3 offset;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, player.position.z + offset.z);
	}
}
