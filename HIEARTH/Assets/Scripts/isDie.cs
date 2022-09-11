using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isDie : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Debug.Log("asdf");
            PlayerManager.isGameOver = true;
            gameObject.SetActive(true);
        }
    }
}
