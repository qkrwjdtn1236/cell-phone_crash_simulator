using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isBackCover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag ==  "plane")
        {
            Debug.Log("액정 안깨짐");
            SceneManager.LoadScene("SampleScene");
        }  
    }
}
