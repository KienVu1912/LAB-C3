using UnityEngine;

public class LifecycleDebugger : MonoBehaviour {
    void Awake() => Debug.Log("<color=cyan>Awake:</color> Khởi tạo");
    void OnEnable() => Debug.Log("<color=green>OnEnable:</color> Kích hoạt");
    void Start() => Debug.Log("<color=blue>Start:</color> Bắt đầu");
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) Debug.Log("Update: Bạn vừa nhấn Space");
    }

    void OnDisable() => Debug.Log("<color=yellow>OnDisable:</color> Vô hiệu hóa");
    void OnDestroy() => Debug.Log("<color=red>OnDestroy:</color> Bị hủy");
}