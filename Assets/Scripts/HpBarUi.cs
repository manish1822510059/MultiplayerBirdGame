using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarUi : MonoBehaviour
{
  
   
    public Image filledBar;
    public Gradient gradient;
    public GameOver gameOver;

    public Text hpText;

    public int minHp,maxHp;
    private int curreentHp;

    private void Start() {
        curreentHp = maxHp;
        UpdateUI();
    }

    public void Heal(int point){
       curreentHp = Mathf.Clamp(curreentHp+point,minHp,maxHp);
       UpdateUI();
    }

    public void Attack(int point){ 
       curreentHp = Mathf.Clamp(curreentHp-point,minHp,maxHp);
       UpdateUI();

    }
    // Update is called once per frame
    void UpdateUI()
    {
        gameOver.GameOverCheck(curreentHp);
        hpText.text = curreentHp.ToString();
        if(maxHp == 0){
            Debug.Log("max Hp Can't be 0");
            return;
        }
        filledBar.fillAmount = (float)curreentHp/maxHp;

        filledBar.color = gradient.Evaluate(filledBar.fillAmount);
    }

  
}
