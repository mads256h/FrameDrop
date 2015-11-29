using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class settingsManager : MonoBehaviour {

    public Camera cam;

    public Canvas settingsCanvas;
    public Canvas mainMenuCanvas;
    public Slider fovSlider;
    public InputField fovSliderNumber;
    public Toggle lagSpikeToggle;
    public Text lagspikeToggleText;
    public Toggle frameDropToggle;
    public Text frameDropToggleText;

    public float getFov = 0.0f;

    public static float fov = 5.0f;
    public static bool lagSpikeEnabled = true;
    public static bool frameDropEnabled = true;

    bool isMenu = false;
    bool isGame = false;

	// Use this for initialization
	void Start () {
	if (cam == null)
        {
            isMenu = true;
            isGame = false;
        }
    if (fovSlider == null)
        {
            isGame = true;
            isMenu = false;
        }
    if (isMenu)
        {
            lagSpikeToggle.isOn = lagSpikeEnabled;
            frameDropToggle.isOn = frameDropEnabled;
            settingsCanvas.enabled = false;

        //Adds a listener to the main slider and invokes a method when the value changes.
        fovSlider.onValueChanged.AddListener(delegate { FovSliderUpdate(true); });

            fovSliderNumber.onValueChange.AddListener(delegate { FovSliderUpdate(false); });
}
    if (isGame)
        {
            cam.orthographicSize = fov;
        }

	}
	
	// Update is called once per frame
	void Update () {
        if (isMenu && settingsCanvas.enabled)
        {
            fov = fovSlider.value;
            lagSpikeEnabled = lagSpikeToggle.isOn;
            frameDropEnabled = frameDropToggle.isOn;
            

            if (lagSpikeToggle.isOn)
            {
                lagspikeToggleText.text = "Enabled";
            }
            else
            {
                lagspikeToggleText.text = "Disabled";
            }

            if (frameDropToggle.isOn)
            {
                frameDropToggleText.text = "Enabled";
            }
            else
            {
                frameDropToggleText.text = "Disabled";
            }
        }
        getFov = fov;

	}

    void FovSliderUpdate(bool isSlider)
    {
        if (isSlider)
        {
            fovSliderNumber.text = fovSlider.value.ToString();
        }
        else
        {
            fovSlider.value = float.Parse(fovSliderNumber.text);
        }
    }

    void FovInputGet(float arg0)
    {

    }
    public void EnableSettings()
    {
        settingsCanvas.enabled = true;
        mainMenuCanvas.enabled = false;
    }

    public void DisableSettings()
    {
        settingsCanvas.enabled = false;
        mainMenuCanvas.enabled = true;
    }
}
