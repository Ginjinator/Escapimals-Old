using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    private int health, speed, power;
    public void setValues(int hp, int sp, int pow)
    {
        health = hp;
        speed = sp;
        power = pow;
    }
    public int getHealth()
    {
        return health;
    }
    public int getSpeed()
    {
        return speed;
    }
    public int getPower()
    {
        return power;
    }
    public void damage(int damage)
    {
        health = health - damage;
    }
}

public class PlayerController : MonoBehaviour {
    public Player myPlayer = new Player();
    // Use this for initialization
    void Start()
    {
        myPlayer.setValues(10, 20, 30);  
    }
       
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
