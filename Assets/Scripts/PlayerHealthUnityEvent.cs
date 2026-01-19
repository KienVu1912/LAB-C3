using UnityEngine;
using UnityEngine.Events; // Thư viện dùng UnityEvent

public class PlayerHealthUnityEvent : MonoBehaviour {
    public int currentHealth = 100;

    // Tạo một UnityEvent hiện ra trong Inspector
    public UnityEvent<string> onHealthChangedEvent; 

    void Update() {
        if (Input.GetKeyDown(KeyCode.G)) { // Nhấn G để test UnityEvent
            currentHealth -= 5;
            // Phát sự kiện với dữ liệu là một chuỗi văn bản
            onHealthChangedEvent.Invoke("HP còn: " + currentHealth);
        }
    }
}