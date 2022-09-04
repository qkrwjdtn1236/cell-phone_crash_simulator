using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isScreenCrash : MonoBehaviour
{
    public GameObject phone;
    public int crack = 0;

    public float heightMin;
    public float heightMax;

    private void OnTriggerEnter(Collider other){
        if(other.tag ==  "plane"){


            Transform transform = phone.GetComponent<Transform>();
            float height = Random.Range(heightMin,heightMax);
            transform.position = new Vector3(0.0f,height*(6.0f/8.0f),0.0f);
            
            float s = Random.Range(0.5f,0.6f);
            float t = Random.Range(15.0f,25.0f);

            transform.rotation = Quaternion.Euler(t,-90,0);
            float w = 2.0f*Mathf.Sqrt((3.0f*9.8f)/0.1633f)*(2.0f*s/1.0f+(3.0f*Mathf.Pow(2.0f*s,2.0f))*Mathf.Sin(t/180.0f*Mathf.PI));

            Rigidbody cellPhone = phone.GetComponent<Rigidbody>();
            cellPhone.AddTorque(Vector3.forward*w,ForceMode.VelocityChange);
            

            crack+=1;
            Debug.Log("x :"+crack);
        }
    }
}
