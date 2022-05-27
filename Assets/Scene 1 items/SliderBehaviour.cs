using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class SliderBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Slider positionSlider;

    bool isSliderBeingControlled = false;
    // Start is called before the first frame update
    void Start()
    {
        positionSlider = GetComponent<Slider>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isSliderBeingControlled = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {

        float frameNumber = positionSlider.value * VideoPlayerManager.Instance.player.frameCount;
        VideoPlayerManager.Instance.player.frame = (long)frameNumber;
        isSliderBeingControlled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isSliderBeingControlled == false)
        {
            positionSlider.value = (float)VideoPlayerManager.Instance.player.frame / VideoPlayerManager.Instance.player.frameCount;
        }
    }
}
