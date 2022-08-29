using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellPhone_ : MonoBehaviour
{
    Rigidbody cellPhone;

    // Start is called before the first frame update
    void Start()
    {
        cellPhone = GetComponent<Rigidbody>();
        cellPhone.AddTorque(new Vector3(0,0,1)*3000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
