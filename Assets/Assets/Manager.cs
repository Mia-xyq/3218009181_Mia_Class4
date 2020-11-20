using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Manager : MonoBehaviour {

    public Sprite[] sprites;
    public static int AllCount;
    public Text text1;
    public GameObject EndImg;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        AllCount = 0;
        for (int i = 0; i < this.transform.childCount; i++)
        {
            this.transform.GetChild(i).gameObject.SetActive(false);
            if (Random.Range(0, 2) == 1)
            {
                this.transform.GetChild(i).gameObject.SetActive(true);
                this.transform.GetChild(i).GetComponent<Block>().BlockHp = Random.Range(1, 4);
                this.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
                AllCount++;
            }
            
        }
	}
	
	// Update is called once per frame
	void Update () {
        text1.text = AllCount.ToString();
        if (AllCount <= 0)
        {
            Time.timeScale = 0;
            EndImg.SetActive(true);
        }
	}
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
