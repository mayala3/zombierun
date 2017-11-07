using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] obstacles;
    public Vector3 spawnValues;

    public float spawnWait;
    public int startWait;

    public float spawnMostWait;
    public float spawnLeastWait;

    private int randEnemy;

    private int[] xValues;

	// Use this for initialization
	void Start () {
        xValues = new int[3];
        xValues[0] = -5;
        xValues[1] = 0;
        xValues[2] = 5;
        StartCoroutine(WaitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
	}

    IEnumerator WaitSpawner() {
        yield return new WaitForSeconds(startWait);

        while (true) {
            randEnemy = Random.Range(0, obstacles.Length);
            Vector3 spawnPosition = new Vector3(xValues[Random.Range(0, 3)], 1, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(obstacles[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), obstacles[randEnemy].transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
