using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoManager : MonoBehaviour
{

    private VideoPlayer videoPlayer;
    public GameObject imageText;
    public GameObject playButton;
    public GameObject pauseButton;
    // Start is called before the first frame update
    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        imageText.SetActive(false);
        playButton.SetActive(false);
        
    }

    public void Play(){

        videoPlayer.Play();
        imageText.SetActive(false);
        pauseButton.SetActive(true);
        playButton.SetActive(false);
    }

    public void Pause(){

        videoPlayer.Pause();
        pauseButton.SetActive(false);
        playButton.SetActive(true);
    }

    public void Home(){
        //videoPlayer.Stop();
        //imageText.SetActive(false);
        SceneManager.LoadScene("hub");
    }

    public void Info(){

        if(imageText.activeSelf){
            imageText.SetActive(false);
        }else{
            imageText.SetActive(true);
        }
        
    }

/*
    public void URLToVideo(string url){
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = url;
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }

    private void VideoPlayer_prepareCompleted(VideoPlayer source){

        Play();
}
*/

}