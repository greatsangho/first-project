using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBronze : MonoBehaviour
{
    void OnTriggerEnter(Collider col){
        if(col.gameObject.name == "Player")
        {
            GameObject.Find("GameManager").SendMessage("GetBronze");
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
