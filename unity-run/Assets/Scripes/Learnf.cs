
using UnityEngine;

public class Learnf : MonoBehaviour
{
    public bool test;

    private void Start()
    {
        if (test)
        {
            print("我是程式悠~!");
        }
        
    }

    public bool opendoor;

    private void Update()
    {
        if (opendoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
    }
}
