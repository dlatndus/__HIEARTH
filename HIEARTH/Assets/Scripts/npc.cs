using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour { 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "npcK")
        {
            //npcTF[0] = true;
            Debug.Log("�ھ˶�");
            gameObject.SetActive(true);
        }

        if (collision.transform.tag == "npcW")
        {
            Debug.Log("����");
            gameObject.SetActive(true);
        }

        if (collision.transform.tag == "npcT")
        {
            Debug.Log("ȣ����");
            PlayerManager.isGameOver = true;
            gameObject.SetActive(true);
        }
    }
}
