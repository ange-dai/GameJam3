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
    // Start is called before the first frame update
    void Start()
    {
      gameOver=false;
      anim=GetComponent<Animator>();
      cam.orthographicSize = 6.27537f;
      cam.transform.position=new Vector3(-0.6f,0.71f,-35.3f);
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gameOver);
        if(Input.anyKey){
          
          if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("WalkRights",true);
            transform.position += Vector3.left * speed * Time.deltaTime;
         }
          if (Input.GetKey(KeyCode.RightArrow)) {
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
      transform.position=new Vector3(25.45f,-4f,-1f);
      cam.orthographicSize = 7.605618f;
      cam.transform.position=new Vector3(25.52f,0.71f,-35.3f);
    }
   if (other.gameObject.CompareTag("past")) {
      transform.position=new Vector3(-24.8f,-4f,-1f);
      cam.transform.position=new Vector3(-25.01f,0.71f,-35.3f);
      cam.orthographicSize = 6.59918f;
    }
   if (other.gameObject.CompareTag("present")) {
     transform.position=new Vector3(0f,-4f,-1f);
     cam.orthographicSize = 6.27537f;
     cam.transform.position=new Vector3(-0.46f,0.71f,-10f);
    }
    
  }
  
}
