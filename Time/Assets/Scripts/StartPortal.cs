using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPortal : MonoBehaviour
{
    public GameObject activator;
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!activator.activeSelf){
            Debug.Log("portalbb");
            portal.SetActive(true);
            Debug.Log("uicnjdkscjnekd");
        }
    }
}
