using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed);
        
    }

    private void OnTriggerEnter2D(Collider2D otherObj)
    {
        DirectionalNode dn = otherObj.GetComponent<DirectionalNode>();
        Debug.Log(dn.current);

        //check direction
        float rot = 0;
        Vector3 dir = Vector3.zero;
        if(dn.current == "right")
        {
            dir = Vector3.back;
            rot = 90;
        }
        else if(dn.current == "left")
        {
            dir = Vector3.forward;
            rot = 90;
        }
        transform.Rotate(dir * rot);//.back goes right, .forward goes left


        /*
        switch(dn.current)
        {
            case "right":
                transform.Rotate(Vector3.back * 90);//.back goes right, .forward goes left
                break;
            case "left":
                transform.Rotate(Vector3.forward * 90);
                break;
            default:
                break;
        }
        */


    }
}
