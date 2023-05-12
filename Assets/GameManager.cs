using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gameOverCanvas;
    public GameObject audioSource;
    private void Start()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void GameOver(){
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        audioSource.GetComponent<AudioSource>().Pause();
    }

    public void Replay(){
        SceneManager.LoadScene(0);
    }

    public void Exit(){
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
