using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienBattleUnit : MonoBehaviour
{
    public BaseAlienScript alien {get; set;}

    public void Setup() {
        alien = GameManager.Instance.alienToFight;
        if (alien is SuperiorAlienScript)
        {
            transform.localScale = new Vector3(2, 2, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        GetComponent<Image>().sprite = alien.sprite;
    }
}
