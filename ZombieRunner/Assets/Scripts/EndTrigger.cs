using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManage gameManager;

    void OnTriggerEnter() {
        gameManager.CompleteLevel();
    }
}
