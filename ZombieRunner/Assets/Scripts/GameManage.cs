using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour {

    bool gameOver = false;

    public float delay = 1f;

    public GameObject completeLevelUI;

    public static int zombies;

    public void EndGame() {
        if (gameOver == false) {
            gameOver = true;
            Invoke("Restart", delay);
        }
    }

    private void Start()
    {
        zombies = 0;
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }
}
