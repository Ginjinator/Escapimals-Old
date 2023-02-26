using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    
    private PlayerController play;
    public GameObject[] Turn;
	// Use this for initialization
	void Start () {
        GameObject pl = GameObject.FindGameObjectWithTag("player");
        GameObject en = GameObject.FindGameObjectWithTag("enemy");
        Turn = new GameObject[5];
        play = pl.GetComponent<PlayerController>();
        print(play.myPlayer.getHealth());
        //play.myPlayer.damage(3);
        print(play.myPlayer.getHealth());
        
        if(play.myPlayer.getSpeed()>3)
        {
            Turn[0] = pl;
            Turn[1] = en;
        }
        if(Turn[0]==pl)
        {
            play.myPlayer.damage(8);
        }
        else
        {
            play.myPlayer.damage(5);
        }
        print(play.myPlayer.getHealth());

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
