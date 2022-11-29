using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCol : MonoBehaviour
{
    public int id;
    // Start is called before the first frame update
    private void Start()
    {
        PlayerCol.current.playerItemInter += ItemAct;
    }

    // Update is called once per frame
   private void ItemAct(int id )
    {
        if(id == this.id){
            
            PlayerCol.current.playerItemInter -=ItemAct;
            Destroy(gameObject);
        }
    }
}
