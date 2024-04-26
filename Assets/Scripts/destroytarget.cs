using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroytarget : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        Debug.Log("target destroy");
        
        var player = GameObject.Find("PlayerTank");
        player.GetComponent<score>().points++;
        AudioManager.Instance.PlaySFX("Out");
    }
}
