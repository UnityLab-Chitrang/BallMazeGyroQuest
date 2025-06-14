using TMPro;
using UnityEngine;

public class LevelStartScreen : UIManager
{
    [SerializeField] GameObject starterScreen;

    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI levelText;

    private void Awake() {
        title.text = $"{Application.productName}";
        levelText.text = $"Level: {gameManager.Level.ToString("D2")}";

//#if UNITY_EDITOR
//        SetScreen(false);
//        gameManager.StartGame();
//#else
//        SetScreen(true);
//#endif
  SetScreen(true);
    }

    internal void SetScreen(bool isEnable) { 
        starterScreen.SetActive(isEnable);
    }
}
