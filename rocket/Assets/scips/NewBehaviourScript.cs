using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 Vec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    void Update()
    {
        Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;
        transform.localPosition = Vec;

        Physics.gravity = new Vector3(0, -1.0F, 0);
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up, -10);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            this.transform.Rotate(Vector3.up, 10);
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(Vector3.down, -10);
        }

        if (Input.GetKey(KeyCode.R))
        {
            this.transform.Rotate(Vector3.down, 10);
        }
    }
}
