
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{

    public GameObject zombie;

    public Transform zombieTran;

    public Camera cam;

    private void Start()
    {
        print(zombie.tag);
        print(zombie.layer);



        zombieTran.position = new Vector3(3, 7, 0);
       // zombieTran.localScale = new Vector3(5, 5, 5);

    }
    private void Update()
    {
        zombieTran.Rotate(0, 0, 60);
        zombieTran.Translate(100, 0, 0);
    }

}
