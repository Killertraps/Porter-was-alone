using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject ground;
    public Text gameText;

    void Start()
    {
        gameText.text = "";
        ground.gameObject.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.Equals("objectHider"))
        {
            Application.LoadLevel(Application.loadedLevel);
            gameText.text = "GAME OVER ! THE PORTER IS STILL ALONE !";
        }
    }
}
