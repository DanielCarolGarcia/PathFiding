using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator mechanim;

    // Start is called before the first frame update
    void Start()
    {
        mechanim = GetComponent<Animator>();
    }

    public void Open()
    {
        mechanim.SetTrigger("ChangeState");
    }

    public void Close()
    {
        mechanim.SetTrigger("ChangeState");
    }
}
