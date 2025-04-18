using UnityEngine;

public class bolita : MonoBehaviour
{
    public float initialSpeed = 1000f;  
    private Rigidbody rb;

    void Start()
    {
       rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionZ;
        rb.AddForce(Vector3.up * 600);
        LaunchBall();
    }

    void LaunchBall()
    {
        Vector3 randomDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, -0.5f), 0).normalized;
         rb.linearVelocity = randomDirection * initialSpeed;  
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("plataforma") || collision.gameObject.CompareTag("bricks"))
        { 
            Vector3 normal = collision.contacts[0].normal;
            Vector3 newDirection = Vector3.Reflect(rb.linearVelocity, normal);
            newDirection.z = 0;
            rb.linearVelocity = newDirection.normalized * initialSpeed;


        }
        if (collision.gameObject.CompareTag("Perdio"))
        {
            Vector3 newdirecc = Vector3.zero;

        }
    }

    void Update()
    {
        
    }
}
