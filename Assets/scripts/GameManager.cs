using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public Text packetsText;
    public Text missedText;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject image1;
    public GameObject image2;
    private int score;
    private int packets;
    private int missedstudents;
    private GameObject Screen;

    public StudentSpawner StudentSpawnerReference;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();

    }
    public void Play()
    {
        score = 0;
        packets = 10;
        missedstudents = 0;
        packetsText.text = packets.ToString();
        scoreText.text = score.ToString();
        missedText.text = missedstudents.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        image1.SetActive(false);
        image2.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

        Students[] studs = FindObjectsOfType<Students>();

        for (int j = 0; j < studs.Length; j++)
        {
            Destroy(studs[j].gameObject);
        }

        PowerUp[] powers = FindObjectsOfType<PowerUp>();

        for (int k = 0; k < powers.Length; k++)
        {
            Destroy(powers[k].gameObject);
        }

    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        playButton.SetActive(true);
        // UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        gameOver.SetActive(true);
        FindObjectOfType<Player>().StrengthReset();
        StudentSpawnerReference.numSpawn = 0;

        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void Packets()
    {
        if (packets != 0)
        {
            packets--;
            packetsText.text = packets.ToString();
            FindObjectOfType<Player>().Acc();
        }

    }

    public void IncreasePackets()
    {
        packets = 10;
        packetsText.text = packets.ToString();
        FindObjectOfType<Player>().StrengthReset();
    }
    public void Missed()
    {
        missedstudents++;
        missedText.text = missedstudents.ToString();
        if (missedstudents > 5)
        {
            GameOver();
            missedstudents = 0;
        }
    }

}

