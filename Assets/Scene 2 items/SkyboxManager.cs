using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class SkyboxManager : MonoBehaviour
{
    public InputField surroundVideoUrl;
    //surround link:
    //https://rr4---sn-hpa7znsz.googlevideo.com/videoplayback?expire=1653653341&ei=_WqQYsW1AvGnx_AP2NwE&ip=95.181.233.9&id=o-AK-tYyCHRsB8VctXqHrUc1bKq_u9a-kMhr1JexTiFpcS&itag=22&source=youtube&requiressl=yes&mh=gt&mm=31%2C29&mn=sn-hpa7znsz%2Csn-hpa7kn7l&ms=au%2Crdu&mv=m&mvi=4&pl=24&initcwndbps=787500&vprv=1&mime=video%2Fmp4&ratebypass=yes&dur=156.548&lmt=1650799558836059&mt=1653631256&fvip=2&fexp=24001373%2C24007246&c=ANDROID&txp=4432434&sparams=expire%2Cei%2Cip%2Cid%2Citag%2Csource%2Crequiressl%2Cvprv%2Cmime%2Cratebypass%2Cdur%2Clmt&sig=AOq0QJ8wRgIhAIX52NfvrNwMBi3kr6cjtGQsGY2C9Ctaqf-dfy0p8r4GAiEAp1lhKcvYPQqjKAFcjENZqk3t61hNig48F_bQXeT1yoU%3D&lsparams=mh%2Cmm%2Cmn%2Cms%2Cmv%2Cmvi%2Cpl%2Cinitcwndbps&lsig=AG3C_xAwRgIhAPYL83fLXOmKx8iwoK3yzWR3XD7kH4r9bSjtKFfNY_MMAiEAvk78Vft64GiYzey6YSFMOPfdfww6fEJZ_Jba9d40Vyo%3D


    public VideoPlayer surroundVideoPlayer;
    // Start is called before the first frame update
  

    public void PlaySurroundVideoWithUrl()
    {
        surroundVideoPlayer.url = surroundVideoUrl.text;
    }
}
