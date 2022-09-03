using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellPhoneRotate : MonoBehaviour
{
    Rigidbody cellPhone;
    
    void Awake(){
        Transform transform = GetComponent<Transform>();
        transform.position = new Vector3(0.0f,Random.Range(0.8f,1.5f),0.0f);
        Debug.Log(transform.position);
    }
    // Start is called before the first frame update
    void Start()
    {
        cellPhone = GetComponent<Rigidbody>();
        cellPhone.AddTorque(new Vector3(0,0,3000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
