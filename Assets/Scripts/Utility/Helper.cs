using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Helper : MonoBehaviour
{
    [SerializeField] private GyroControl gyro;

    [SerializeField] private Slider speedSlider;
    [SerializeField] private TextMeshProUGUI speedSliderText;

    [SerializeField] private Slider smoothSlider;
    [SerializeField] private TextMeshProUGUI smoothSliderText;

    private void Start() {

    }

    private void UtilityHelper() {
        speedSlider.minValue = 0;
        speedSlider.maxValue = 2000;

        speedSlider.onValueChanged.AddListener((val) => {
            gyro.speed = val;
            speedSliderText.text = "Speed: " + val.ToString();
        });

        smoothSlider.minValue = 0;
        smoothSlider.maxValue = 1;

        smoothSlider.onValueChanged.AddListener((val) => {
            smoothSliderText.text = "Smooth: " + val.ToString();
        });

        speedSlider.onValueChanged.Invoke(1000);
        smoothSlider.onValueChanged.Invoke(0.1f);
    }
}
