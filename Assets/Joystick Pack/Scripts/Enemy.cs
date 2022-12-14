using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position,target.position);
        Vector3 targetPos;
        if (dist<8){
            targetPos = new Vector3(transform.position.x,0,transform.position.z);
        }
        else{
            targetPos = new Vector3(transform.position.x,-2,transform.position.z);
        }
        transform.position = Vector3.Lerp(transform.position,targetPos,0.05f);
    }
    
}
