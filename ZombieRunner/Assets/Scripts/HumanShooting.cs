using System.Collections;
using UnityEngine;

public class HumanShooting : MonoBehaviour {

    public float startWait;
    public float spawnWait;
    public GameObject bullet;

	// Use this for initialization
	void Start () {
        StartCoroutine(WaitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator WaitSpawner() {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            Vector3 spawnPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 2);
            Instantiate(bullet, spawnPosition, bullet.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
