using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interacable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //hàm này là chỗ mình tạo ra tương tác dùng code
    protected override void Intercact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("isOpen", doorOpen);
    }
}