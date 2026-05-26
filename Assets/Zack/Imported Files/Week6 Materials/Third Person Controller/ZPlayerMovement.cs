using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZPlayerMovement : MonoBehaviour{

    public Animator anim;

    public float rotSpeed = 10;
    Horror1Script HorrorScript;

    // Start is called before the first frame update
    void Start()
    {
        HorrorScript = GameObject.FindGameObjectWithTag("Horror1").GetComponent<Horror1Script>();
    }

    // Update is called once per frame
    void Update(){

        ForwardMovement();

        Turning();

        Actions();

    }

    private void ForwardMovement(){
        if(Input.GetKey("w")){
            anim.SetBool("Walking", true);
            if (Input.GetKey(KeyCode.LeftShift) & HorrorScript.StopRunning == false)
            {
                anim.SetBool("Running", true);
            } else{
                anim.SetBool("Running", false);
            }
        } else if (Input.GetKeyUp("w")) {
            anim.SetBool("Walking", false);
            anim.SetBool("Running", false);
        }
    }

    private void Turning(){
        if (Input.GetKey("a")) {
            transform.Rotate(0, -rotSpeed * 15 * Time.deltaTime, 0, Space.World);
            anim.SetBool("Turn Left", true);
        } else if (Input.GetKey("d")) {
            transform.Rotate(0, rotSpeed * 15 * Time.deltaTime, 0, Space.World);
            anim.SetBool("Turn Right", true);
        } else {
            anim.SetBool("Turn Left", false);
            anim.SetBool("Turn Right", false);
        }
    }

    private void Actions(){
        if(Input.GetKeyDown("e")){
            anim.SetBool("Waving", true);
        } else if(Input.GetKeyUp("e")){
            anim.SetBool("Waving", false);
        }
    }
}
