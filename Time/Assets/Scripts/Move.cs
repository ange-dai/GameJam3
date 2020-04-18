using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.5f;
    private Vector3 spawnPoint= new Vector3(-1.05f,-4.67f,-1f);
    public bool gameOver;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      gameOver=false;
      anim=GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gameOver);
        if(Input.anyKey){
          
          if (Input.GetKey(KeyCode.LeftArrow)&&transform.position.x>-10.55) {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("WalkRights",true);
            transform.position += Vector3.left * speed * Time.deltaTime;
         }
          if (Input.GetKey(KeyCode.RightArrow)&&transform.position.x<10.51) {
            anim.SetBool("WalkRights",true);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            transform.position += Vector3.right * speed * Time.deltaTime;
          }
          if (Input.GetKey(KeyCode.UpArrow)) {
            anim.SetBool("WalkRights",false);
            anim.SetBool("isJumping",true);
            transform.Translate(Vector3.up * 7 * Time.deltaTime, Space.World);
          }
          if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += Vector3.down * speed * Time.deltaTime;
          }
        }else{
            anim.SetBool("WalkRights",false);
            anim.SetBool("isJumping",false);
           
        }
    
        
    
    }
  
}
