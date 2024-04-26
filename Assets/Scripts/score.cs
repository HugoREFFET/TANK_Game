using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public float points;
    public GameObject canva;
    
    void Update()
    {
        if (points >= 5f)
        {
            Debug.Log("win");
            canva.SetActive(true);
            //Time.timeScale = 0;
            AudioManager.Instance.StopMusic("Theme");
            AudioManager.Instance.PlaySFX("Victory");
        }
    }
}
