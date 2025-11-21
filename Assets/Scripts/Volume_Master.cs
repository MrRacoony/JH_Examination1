using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume_Master : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] AudioMixer mixer;
    private void Start()
    {
        setVolume(PlayerPrefs.GetFloat("SavedMasterVolume"));
    }

    public void setVolume(float volume)
    {
        if (volume < 1)
        {
            volume = .001f;
        }
        
        RefreshSlider(volume);
        PlayerPrefs.SetFloat("SavedMasterVolume", volume);
        mixer.SetFloat("MasterVolume", Mathf.Log10(volume/100) * 20f);
    }

    public void setVolumeSlider()
    {
        setVolume(slider.value);
    }

    public void RefreshSlider(float value)
    {
        slider.value = value;
    }

}
