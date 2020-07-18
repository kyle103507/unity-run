using UnityEngine;

public class LearLerp : MonoBehaviour
{
    public int A = 0;
    public int B = 10;

    public float C = 0;
    public float D = 100;

    public Vector2 v2A = new Vector2(0, 0);
    public Vector2 v2B = new Vector2(100, 100);


    void Start()
    {
        float r = Mathf.Lerp(A, B, 0.7f);

        print(r);
    }

    private void Update()
    {
        C = Mathf.Lerp(C, D, 0.5f*Time.deltaTime);

        v2A = Vector2.Lerp(v2A, v2B, 0.5f * Time.deltaTime);


    }
}
