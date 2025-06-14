using System.Xml.Serialization;
using UnityEngine;

public class LevelCompleteScreen:UIManager {
    [SerializeField] GameObject levelCompleteScreen;
    private void Awake() {
        levelCompleteScreen.SetActive(false);
    }

    internal void OnLevelCompleted() {
        levelCompleteScreen.SetActive(true);
    }

    internal void SetScreen(bool isEnable) {
        levelCompleteScreen.SetActive(isEnable);
    }
}
