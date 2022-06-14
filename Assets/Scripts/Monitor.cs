using UnityEngine.Video;
using UnityEngine;

public class Monitor : InteractableObject
{

    public VideoPlayer videoPlayer;
    public string videoAsset;

    private void Awake() {
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, videoAsset); 
    }

    public override void Activate(){
        videoPlayer.Play();
    }


}