using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 20f;
    public VariableJoystick moveJoyStick;
    public VariableJoystick rotateJoyStick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        float r = rotateJoyStick.Horizontal;

        if(h == 0 && v == 0)
        {
            h = moveJoyStick.Horizontal;
            v = moveJoyStick.Vertical;
        }


        Vector3 dir = Vector3.right * h + Vector3.forward * v;
        transform.Translate(dir * moveSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, 1, 0) * rotateSpeed * r);
    }
}
