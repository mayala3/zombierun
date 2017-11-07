using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanCollision : MonoBehaviour {

    public float delay;

    /*void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Zombie" && gameObject.tag == "Human")
        {
            GetComponent<FollowZombie>().enabled = true;
            GetComponent<FollowZombie>().player = collisionInfo.collider.gameObject.transform;
            GetComponent<AudioSource>().Play();
            gameObject.tag = "Zombie";
            GameManage.zombies++;
        }

        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<FollowZombie>().enabled = false;
            GameManage.zombies--;
            Invoke("Remove", delay);
        }
    }

    void Remove() {
        Destroy(gameObject);
    }*/
}
