using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            GameManage.zombies--;
            transform.localScale -= new Vector3(0.3f, 0.3f, 0.3f);
            Destroy(collisionInfo.collider.gameObject);
            if (GameManage.zombies < 0) {
                movement.enabled = false;
                FindObjectOfType<GameManage>().EndGame();
            }
        }
        if (collisionInfo.collider.tag == "Human") {
            GetComponent<AudioSource>().Play();
            GameManage.zombies++;
            transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);
            Destroy(collisionInfo.collider.gameObject);
            //movement.sidewaysForce;
        }
    }
}
