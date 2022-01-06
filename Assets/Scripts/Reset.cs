using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public int BallCounter = 0;
    //
    public GameObject Ball;
    public Transform Platform;
    //
    public string BallUsed;
    public GameObject BallsUI;

    //Reset la ball
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            BallCounter++;
            Instantiate(Ball,Platform.position, Platform.rotation) ;
            Destroy(this.gameObject);
            print(BallCounter);
        }
    }

    void Update()
    {
        BallUsed = BallCounter.ToString();
        BallsUI.GetComponent<Text>().text = BallUsed;

    }
}
