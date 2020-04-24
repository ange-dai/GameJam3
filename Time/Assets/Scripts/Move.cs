using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.5f;
    private Vector3 spawnPoint= new Vector3(-1.05f,-4.67f,-1f);
    public bool gameOver;
    public Camera cam;
    private Animator anim;
    private float left=-10.55f;
    private float right=10.51f;
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
          
          if (Input.GetKey(KeyCode.LeftArrow)&&transform.position.x>left) {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("WalkRights",true);
            transform.position += Vector3.left * speed * Time.deltaTime;
         }
          if (Input.GetKey(KeyCode.RightArrow)&&transform.position.x<right) {
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
  public void OnTriggerEnter2D(Collider2D other) {
   if (other.gameObject.CompareTag("future")) {
      transform.position=new Vector3(25.34f,-4f,-1f);
      cam.transform.position=new Vector3(25.33f,0f,-10f);
      right=32.42f;
      left=17.32f;
    }
   if (other.gameObject.CompareTag("past")) {
      transform.position=new Vector3(-24.8f,-4f,-1f);
      cam.transform.position=new Vector3(-24.57f,0f,-10f);
      right=-15.51f;
      left=-32.96f;
    }
   if (other.gameObject.CompareTag("present")) {
     transform.position=new Vector3(0f,-4f,-1f);
     cam.transform.position=new Vector3(0,0f,-10f);
     right=7.75f;
     left=-6.41f;
    }
    
  }
  
}
