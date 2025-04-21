using UnityEngine;

public class walls : MonoBehaviour
{
    [Header("Rebote Pelota")]
    [SerializeField] private float maxBounceAngle = 45f; // �ngulo m�ximo de rebote en grados

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            // Obtener la posici�n relativa del impacto en la pared
            float hitPosition = (collision.transform.position.y - transform.position.y) / (GetComponent<Collider>().bounds.size.y / 2);
            float bounceAngle = hitPosition * maxBounceAngle * Mathf.Deg2Rad;

            // Determinar la direcci�n del rebote
            Vector3 bounceDirection = new Vector3(0, Mathf.Cos(bounceAngle), Mathf.Sin(bounceAngle));

            // Mantener la velocidad constante
            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
            float currentSpeed = ballRb.linearVelocity.magnitude;
            ballRb.linearVelocity = bounceDirection.normalized * currentSpeed;
        }
    }
}
