using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cellPhoneRotate : MonoBehaviour
{
    Rigidbody cellPhone;
    public int weight;

    public float heightMin;
    public float heightMax;
    
    
    float w;


    // 데이터 추출해야하는 변수들////////////
    public float height;
    public float t;
    public float s;
    ////////////////////////////////////////
    
    void Awake(){
        Transform transform = GetComponent<Transform>();
        height = Random.Range(heightMin,heightMin);
        transform.position = new Vector3(0.0f,height*(6.0f/8.0f),0.0f);
        Debug.Log(transform.position);
        
        s = Random.Range(0.5f,0.6f);
        
        t = Random.Range(15.0f,25.0f);

        transform.rotation = Quaternion.Euler(t,-90,0);
        w = 2.0f*Mathf.Sqrt((3.0f*9.8f)/0.1633f)*(2.0f*s/1.0f+(3.0f*Mathf.Pow(2.0f*s,2.0f))*Mathf.Sin(t/180.0f*Mathf.PI));
    }
    // Start is called before the first frame update
    void Start()
    {
        cellPhone = GetComponent<Rigidbody>();
        cellPhone.AddTorque(Vector3.forward*w,ForceMode.VelocityChange);
    }

    void Update()
    {
        
    }
}
