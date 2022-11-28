using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerCol : MonoBehaviour
{
    public static PlayerCol current;
    // Start is called before the first frame update
    private void Awake()
    {
        current = this;
    }

    // Update is called once per frame
    public event Action<int> playerItemInter;

    public void gamerItemInter(int id)
    {
        if(playerItemInter!= null){
            playerItemInter(id);
        }
        
    }
}
