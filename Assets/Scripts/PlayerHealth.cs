using UnityEngine;
using System; // Bắt buộc phải có dòng này để dùng Action
using UnityEngine.Events;
public class PlayerHealth : MonoBehaviour {
    // Lỗi thường do thiếu dòng này hoặc sai tên
    public static event Action<int> OnHealthChanged; 
    public UnityEvent onDeath;
    public int health = 100;

    public void TakeDamage(int damage) {
        health -= damage;
        if (health <= 0) return;
        health -= damage;
        // Kích hoạt sự kiện cho Lab 5 (C# Event)
        OnHealthChanged?.Invoke(health); 
        if (health <= 0) {
            health = 0;
            onDeath.Invoke(); // Phát tín hiệu Game Over
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.H)) {
            TakeDamage(10);
        }
    }
}