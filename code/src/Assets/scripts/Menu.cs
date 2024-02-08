using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Menu : MonoBehaviour
{
    public string nextSceneName;
    public VideoPlayer videoPlayer;
    public Button pauseVideo;
    public Button playVideo;
    public Button Home; 
    
    void Start()
    {
         pauseVideo.onClick.AddListener(OnPauseVideo);
         playVideo.onClick.AddListener(OnPlayVideo);
         Home.onClick.AddListener(OnHome);
         videoPlayer.loopPointReached += OnVideoEnd;
    }
    public void OnPauseVideo(){
        videoPlayer.Pause();
    }
      public void OnPlayVideo()
    {
        videoPlayer.Play();
    }
    public void OnHome()
    {
        SceneManager.LoadScene(nextSceneName);
    }
    void OnVideoEnd(VideoPlayer vp)
    {
        // Charger la scène suivante lorsque la vidéo est terminée
        SceneManager.LoadScene(nextSceneName);
    }
}