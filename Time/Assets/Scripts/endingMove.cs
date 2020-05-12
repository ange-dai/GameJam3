using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingMove : MonoBehaviour
{
    public float speed;
    private Animator anim;
    public GameObject astro;
    public float right;
    public float left;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        cam.orthographicSize = 5f;
        cam.transform.position = new Vector3(0f, 0f, -10f);
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.anyKey)
        {
            if (Input.GetKey(KeyCode.LeftArrow)&&astro.transform.position.x>=left)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                anim.SetBool("WalkRights", true);
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow)&&astro.transform.position.x<=right)
            {
                anim.SetBool("WalkRights", true);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                anim.SetBool("WalkRights", false);
                anim.SetBool("isJumping", true);
                transform.Translate(Vector3.up * 7 * Time.deltaTime, Space.World);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
        }
        else
        {
            anim.SetBool("WalkRights", false);
            anim.SetBool("isJumping", false);

        }
        
    }
}
