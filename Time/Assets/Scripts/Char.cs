using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
  public float start;
  public  float end;
  public  float speed=5;
  public int direction;    // Start is called before the first frame update
  void Start(){
       
        
  }

  // Update is called once per frame
  void Update(){
    transform.Translate(speed * direction * Time.deltaTime, 0,  0);
    checkDir();
  }
  
  public void checkDir(){
   if (transform.position.x >= end){
      direction=-1;
    }else if (transform.position.x <= start){
      direction=1;
    }
  }
         
    
       
}

        
        
    

