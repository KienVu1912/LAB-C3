using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện để load lại cảnh

public class GameController : MonoBehaviour {
    public GameObject gameOverPanel;

    // Hàm này sẽ được gọi bởi Event OnDeath
    public void ShowGameOver() {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // Dừng thời gian trong game lại
    }

    // Hàm gắn vào Button Restart
    public void RestartGame() {
        Time.timeScale = 1f; // Mở lại thời gian
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}