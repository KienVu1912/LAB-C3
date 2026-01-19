using UnityEngine;
using TMPro; // Thư viện để điều khiển TextMeshPro

public class HealthDisplay : MonoBehaviour {
    public TextMeshProUGUI healthText;

    private void OnEnable() {
        // Đăng ký lắng nghe sự kiện từ PlayerHealth
        PlayerHealth.OnHealthChanged += UpdateHealthUI;
    }

    private void OnDisable() {
        // Hủy đăng ký khi không cần nữa để tránh lỗi bộ nhớ
        PlayerHealth.OnHealthChanged -= UpdateHealthUI;
    }

    void UpdateHealthUI(int newHealth) {
        healthText.text = "HP: " + newHealth;
    }
}