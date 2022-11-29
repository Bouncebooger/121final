using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public int id;
    public GameObject light;
    private int sussy;
    // Start is called before the first frame update
  // Start is called before the first frame update
    private void Start()
    {
        sussy = 0;
        PlayerCol.current.playerItemInter += CauldUse;
    }

    // Update is called once per frame
   private void CauldUse(int id )
    {
        if(sussy<4){
            sussy++;
        }
        else{

        
            

           light.SetActive(true);
        }
          
        }
    }

