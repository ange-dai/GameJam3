using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float right;
    public float left;
    public float speed;
    //for dir: true=right; false=left
    public bool dir;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     if (!dir) {
         transform.localRotation = Quaternion.Euler(0, 180, 0);
         transform.position += Vector3.left * speed * Time.deltaTime;
      }
     if (dir) {
         transform.localRotation = Quaternion.Euler(0, 0, 0);
         transform.position += Vector3.right * speed * Time.deltaTime;
      }
      checkDir();
    }
    private void checkDir(){
        if(transform.position.x<left&&!dir){
            dir=true;
        }else if(transform.position.x>right&&dir){
            dir=false;
        }
    }
}
