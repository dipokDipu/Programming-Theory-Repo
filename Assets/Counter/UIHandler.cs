using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public Text timeText;
    public Text CounterText;
    private float totalTime = 20f;
    public GameObject restart ,gameWin , gameOver;
    public int count;

    public static UIHandler instance;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        count = 10;
        timeText.text = "Time Remaining: " + (int)totalTime;
    }

    // Update is called once per frame
    void Update()
    {

        if(BoxController.instance.GameStart)
        {
            if (totalTime <= 0.0f)
            {
                BoxController.instance.GameOver = true;
                gameWin.SetActive(true);
                restart.SetActive(true);
                return;
            }

            if (count <= 0)
            {
                BoxController.instance.GameOver = true;
                gameOver.SetActive(true);
                restart.SetActive(true);
                return;
            }
            totalTime -= Time.deltaTime;
            timeText.text = "Time Remaining: " + (int)totalTime;
        }
       
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame(Button button)
    {
        button.gameObject.transform.parent.gameObject.SetActive(false);
        BoxController.instance.GameStart = true;
        GameObject.FindObjectOfType<sphereManager>().GetComponent<sphereManager>().StartCoroutine("makeSphere");
    }
}
