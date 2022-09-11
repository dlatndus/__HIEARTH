using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour { 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "npcK")
        {
            //npcTF[0] = true;
            Debug.Log("코알라");
            gameObject.SetActive(true);
        }

        if (collision.transform.tag == "npcW")
        {
            Debug.Log("나무");
            gameObject.SetActive(true);
        }

        if (collision.transform.tag == "npcT")
        {
            Debug.Log("호랑이");
            PlayerManager.isGameOver = true;
            gameObject.SetActive(true);
        }
    }
}
