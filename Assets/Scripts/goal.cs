using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goal : MonoBehaviour
{
    private int NbrPanier = 0;
    private int Score = 0;

    public GameObject ScoreUI;
    public GameObject PanierUI;

    private string ScoreString;
    private string panierString;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            //print("but");
            NbrPanier++;
            Score = Score +3;
        }
    }

    private void Update()
    {
        panierString = NbrPanier.ToString();
        PanierUI.GetComponent<Text>().text = panierString;

        ScoreString = Score.ToString();
        ScoreUI.GetComponent<Text>().text = ScoreString;
    }
}
