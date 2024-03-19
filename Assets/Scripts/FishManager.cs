using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishManager : MonoBehaviour
{
    public static FishManager instance;
    public int Fish;
    [SerializeField] private TMP_Text ScoreText;
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (Fish < 0)
            FinishManager.instance.isFinish = true;
    }
    public void ChangeFish(int value, int process)
    {
        if (process == 1)
            Fish *= value;
        else
            Fish += value;

        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        ScoreText.text = "Fish : " + Fish ;
    }
    /*
    her cisme ayrý kod yerine ayný kodu hepsine at prefablarýndan istedigin degiskeni degistir
    
    */
}
