using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 5f;

    void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Lab 2: Normalize để tránh đi chéo nhanh
        Vector3 dir = new Vector3(h, 0, v).normalized;
        transform.Translate(dir * speed * Time.deltaTime, Space.World);

        // Lab 4: Tính Signed Angle so với trục Forward (Z)
        if (dir != Vector3.zero) {
            float angle = Vector3.SignedAngle(Vector3.forward, dir, Vector3.up);
            Debug.Log("Góc di chuyển hiện tại: " + angle);
        }
    }

    // Lab 2: Vẽ Gizmos hướng di chuyển
    void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * 2f);
    }
}