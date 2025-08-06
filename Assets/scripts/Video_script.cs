using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class video_scripts : MonoBehaviour
{
    public GameObject VideoCube;
    private VideoPlayer videoPlayer;
    public GameObject button; // Updated GameObject name
    //public GameObject ButtonCube;

    private void Start()
    {
        videoPlayer = VideoCube.GetComponent<VideoPlayer>();
        // Assuming the button has a Button component attached for interaction
        button.GetComponent<Button>().onClick.AddListener(ToggleVideo);
    }

    public void ToggleVideo()
    {
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
            //ButtonCube.GetComponent<Renderer>().material.color = Color.gray;
        }
        else
        {
            videoPlayer.Pause();
            //ButtonCube.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
