using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class videoscript : MonoBehaviour
{
    UnityEngine.Video.VideoPlayer video;

    void Start()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer video)
    {
        SceneManager.LoadScene(1);
    }

}
