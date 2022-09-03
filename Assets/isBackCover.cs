using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isBackCover : MonoBehaviour
{
    bool isTrigger;
    // Start is called before the first frame update
    void Start()
    {
        isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag ==  "plane")
        {
            isTrigger = true;
            Debug.Log("액정 안깨짐");
            SceneManager.LoadScene("SampleScene");
        }  
    }
}
