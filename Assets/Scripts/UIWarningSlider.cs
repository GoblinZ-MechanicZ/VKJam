using UnityEngine;
using UnityEngine.UI;

public class UIWarningSlider : MonoBehaviour
{
    public Slider warningSlider;
    public Image warningImage;
    public Color startColor, endColor;
    public float incSpeed = 2f;
    
    private void Start() {
        warningSlider.value = 0f;
    }

    private void Update() {
        warningSlider.value += Time.deltaTime * incSpeed;
        warningImage.color = Color.Lerp(startColor, endColor, warningSlider.value / warningSlider.maxValue);
    }
}
