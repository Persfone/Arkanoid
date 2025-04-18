using UnityEngine;

public class Bricks : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball")) // Comprueba si el objeto que colisiona es la pelota
        {
            Destroy(gameObject); // Destruye el ladrillo
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
