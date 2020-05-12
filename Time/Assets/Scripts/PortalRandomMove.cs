using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRandomMove : MonoBehaviour
{
    public float startX;
    public  float endX;
    public float startY;
    public  float endY;
    private  float speed1;
    private  float speed2;
    public int direction1; 
    public int direction2; 
    private Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        speed1 = 10*Random.Range(0.0f, 1.0f);
        speed2= 10*Random.Range(0.0f, 1.0f);
        scaleChange = new Vector3(0.002f, 0.002f, 0.002f);
    }

    // Update is called once per frame
    void Update()
    {
     checkDir();
     transform.Translate(speed1 * direction1 * Time.deltaTime, speed2 * direction2 * Time.deltaTime, 0);
     transform.localScale += scaleChange;
        
    }
    public void checkDir(){
     if (transform.position.x >= endX){
      direction1=-1;
      speed1 = 10*Random.Range(0.0f, 1.0f);
      scaleChange = -scaleChange;
      //speed2= rnd.NextDouble();
     }else if (transform.position.x <= startX){
      direction1=1;
      speed1 = 10*Random.Range(0.0f, 1.0f);
      scaleChange = -scaleChange;
      //speed2= rnd.NextDouble();
     }else if (transform.position.y <= startY){
      direction2=1;
      scaleChange = -scaleChange;
      //speed1 = rnd.NextDouble();
      speed2= 10*Random.Range(0.0f, 1.0f);
     }else if (transform.position.y >= endY){
      direction2=-1;
      //speed1 = rnd.NextDouble();
      speed2= 10*Random.Range(0.0f, 1.0f);
      scaleChange = -scaleChange;
     }
    }
}
