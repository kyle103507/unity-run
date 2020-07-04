using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    private void Start()
    {
        print(Mathf.PI);
        //0-1隨機數值
        print(Random.value);
        print(Mathf.Abs(999999999999999999));
        print(Random.Range(200, 500+1));
    }
    private void Update()
    {
       // print(Time.time);
    }

}
