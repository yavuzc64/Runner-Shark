using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FinishManager : MonoBehaviour
{
    public static FinishManager instance;
    public bool isFinish = false;
    [SerializeField] private GameObject FinishPanel;
    [SerializeField] private TMP_Text FinalPanelText;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (isFinish)
        {
            FinishPanel.SetActive(true);
            FinalPanelText.text = "Skorun : " + FishManager.instance.Fish;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(0); // Sahne indeksi 0 olan sahneyi yükle
    }
}
