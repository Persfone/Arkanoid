using UnityEngine;

public class mec1 : MonoBehaviour
{
    
    void Start()
    {
        
    }

     
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
    }
}
