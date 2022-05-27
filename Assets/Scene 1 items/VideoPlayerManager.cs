using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

//demo 2d video link:  https://rr1---sn-a5mekn6z.googlevideo.com/videoplayback?expire=1653653525&ei=tWuQYu7AKc-UkwatiJ34BA&ip=185.206.222.53&id=o-AOVV0guhFhwWxj6fxMCX7dvEFJUHXj26Helj3aWHpcJL&itag=22&source=youtube&requiressl=yes&mh=2r&mm=31%2C29&mn=sn-a5mekn6z%2Csn-a5msenek&ms=au%2Crdu&mv=u&mvi=1&pl=22&vprv=1&mime=video%2Fmp4&cnr=14&ratebypass=yes&dur=2103.565&lmt=1626590831456154&mt=1653631377&fvip=1&fexp=24001373%2C24007246&c=ANDROID&txp=5535432&sparams=expire%2Cei%2Cip%2Cid%2Citag%2Csource%2Crequiressl%2Cvprv%2Cmime%2Ccnr%2Cratebypass%2Cdur%2Clmt&sig=AOq0QJ8wRQIgMk7cJudJxE7KIRH4A6yXJt9P_4xeqec9qc7W3vVSfZoCIQDlr2U0FOMbqM52T85ePflLKA38yHeffiZftD49coy7mQ%3D%3D&lsparams=mh%2Cmm%2Cmn%2Cms%2Cmv%2Cmvi%2Cpl&lsig=AG3C_xAwRAIgcgGmQ-P7-KyEqo_kq13yIDlsRuJFUg9_6fpPeOTb_y8CIHFte1iU50ngRTKbhckty4doVwo9CgCY2FKp1SfVMf83
public class VideoPlayerManager : MonoBehaviour
{
    public static VideoPlayerManager Instance;

    public VideoPlayer player;
    public InputField urlInput;

    private void Awake()
    {
        Instance = this;
    }

    public  void GoWithUrl()
    {
        player.url = urlInput.text;
    }

    bool videoPlaying;
    // Start is called before the first frame update
    void Start()
    {
        videoPlaying = true;
        //player.url = urlInput.text;
        //  isSliderBeingControlled = false;        
    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayPauseToggle();
        }
    }

    public void PauseVideo()
    {
        player.Pause();
        videoPlaying = false;
    }

    public void PlayVideo()
    {
        player.Play();
        videoPlaying = true;
    }

    public void PlayPauseToggle()
    {
        if (videoPlaying)
        {
            PauseVideo();
        }
        else
        {
            PlayVideo();
        }
    }

    public void StopVideo()
    {
        player.Stop();
    }

    public void ReplayVideo()
    {
        player.frame = 0;
    }


    public void MuteAudio()
    {
        player.SetDirectAudioVolume(1, 0);
    }
}
