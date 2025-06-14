using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager:MonoBehaviour {
    [SerializeField] internal int Level;

    [SerializeField] StartingPoint startingPoint;
    [SerializeField] LevelStartScreen startScreenUI;
    [SerializeField] LevelCompleteScreen levelCompleteScreenUI;
    [SerializeField] Slider speedSlider;
    [SerializeField] Slider smoothSlider;
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] TextMeshProUGUI speedText;
    [SerializeField] TextMeshProUGUI smoothText;
    private void Start() {
        StartGame();
        GyroControl gyroControl = FindObjectOfType<GyroControl>();
        speedSlider.onValueChanged.AddListener(value => {
            gyroControl.speed = value;
            speedText.text = $"Speed: {value:F2} m/s";
        });
        smoothSlider.onValueChanged.AddListener(value => {
            gyroControl.smoothTime = value;
            smoothText.text = $"Smooth Time: {value:F2} s";
        });
        dropdown.onValueChanged.AddListener(value => {
            switch (value) {
                case 0:
                gyroControl.forceMode = ForceMode.Force;
                break;
                case 1:
                gyroControl.forceMode = ForceMode.Acceleration;
                break;
                case 2:
                gyroControl.forceMode = ForceMode.VelocityChange;
                break;
                case 3:
                gyroControl.forceMode = ForceMode.Impulse;
                break;
            }
        });
    }
    
    [ContextMenu("StartGame")]
    public void StartGame() {
        startingPoint.LaunchPlayer();
        //startScreenUI.SetScreen(false);
    }

    internal void OnLevelCompleted() { 
        //levelCompleteScreenUI.SetScreen(true);
    }

    internal void OnClickNextLevelButton() { 
        
    }
}

