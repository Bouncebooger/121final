using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrig : MonoBehaviour
{
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        
        PlayerCol.current.gamerItemInter(this.id);
    }
}
