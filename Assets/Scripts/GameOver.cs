using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField]  public float countdownDuration = 60f;
  
    private float currentTime;
    
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private TextMeshProUGUI timerText;

    
    // float timer = 0f; 

    
     private void Start()
    {
        currentTime = countdownDuration;
    }

   

    // Update is called once per frame
    public  void GameOverCheck(int curreentHp){
        if(curreentHp == 0){
            gameOverScreen.SetActive(true);
            Movement.PlayerMoving = false;
        }
    }
   
 private void Update()
    {
        if (currentTime > 1f && Movement.PlayerMoving)
        {
            currentTime -= Time.deltaTime;
            timerText.text = FormatTime(currentTime);
        }
        else if(Movement.PlayerMoving)
        {
            currentTime = 0f; 
            gameOverScreen.SetActive(true);
            Movement.PlayerMoving = false;
            Debug.Log("complete time");       
        }
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        return string.Format("{0}:{1:00}", minutes, seconds);
    }



}
