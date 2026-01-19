using UnityEngine;

public class TurretLook : MonoBehaviour {
    public Transform target; // Kéo Player vào đây
    public float lerpSpeed = 5f;
    public bool useSmoothRotation = true;

    void Update() {
        Vector3 direction = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        if (useSmoothRotation) {
            // Lab 3: Slerp để xoay mượt
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * lerpSpeed);
        } else {
            // Xoay trực tiếp (LookAt)
            transform.LookAt(target);
        }
    }
}