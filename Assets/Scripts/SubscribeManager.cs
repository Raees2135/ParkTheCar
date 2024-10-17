using UnityEngine;

public class SubscribeManager : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject failedPanel;
    public GameObject completePanel;


    private void OnEnable()
    {
        ObstacleCollision.onLevelFailed += HandleLevelFailed;
        Trigger.onLevelComplete += HandleLevelComplete;
    }

    private void OnDisable()
    {
        ObstacleCollision.onLevelFailed -= HandleLevelFailed;
        Trigger.onLevelComplete -= HandleLevelComplete;
    }

    private void HandleLevelFailed()
    {
        failedPanel.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("Level Failed");
    }

    private void HandleLevelComplete()
    {
        completePanel.SetActive(true);
        Time.timeScale = 0;
        gameManager.LevelUnlock();
        Debug.Log("Level Complete");
    }
}
