using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public float scalingSpeed = 0.00001f;
    bool scaleUp = false ;
    bool scaleDown = false ;

    // Update is called once per frame
    void Update()
    {

        if (scaleUp){

            scaleUpbutton();
        }
        if (scaleDown){

            scaleDownbutton();
        }
        
    }

    public void scaleUpbutton(){

        GameObject.FindWithTag("Avatar").transform.localScale += new Vector3(scalingSpeed,scalingSpeed,scalingSpeed);

    }

    public void scaleDownbutton(){

        GameObject.FindWithTag("Avatar").transform.localScale += new Vector3(-scalingSpeed,-scalingSpeed,-scalingSpeed);
    }

    public void UP(){
        scaleUp=true;
        scaleDown=false;
    }

    public void DOWN(){
        scaleUp=false;
        scaleDown=true;
    }

    public void STOP(){
        scaleUp=false;
        scaleDown=false;
    }
}
