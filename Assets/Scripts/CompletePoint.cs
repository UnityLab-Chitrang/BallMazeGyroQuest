using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class CompletePoint:MonoBehaviour {
    [SerializeField] GameManager gameManager;

    private void Awake() {
        SphereCollider collider = GetComponent<SphereCollider>();
        collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag(Tag.Player)) {
            Debug.Log("Level Completed");
            gameManager.OnLevelCompleted();
        }
    }
}
