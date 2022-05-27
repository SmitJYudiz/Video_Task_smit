using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VolumeSliderBehaviour : MonoBehaviour, IPointerUpHandler
{
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider = GetComponent<Slider>();
    }

 

    public void OnPointerUp(PointerEventData eventData)
    {
        VideoPlayerManager.Instance.player.SetDirectAudioVolume(0, volumeSlider.value);
    }

  
}
