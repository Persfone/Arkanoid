using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  


public class Vidas : MonoBehaviour
{
    int vidas = 3;
    public Text texto;
    void Start()
    {
        vidas = 3;  

    }
 
    void Update()
    {
        texto.text = vidas.ToString();
        if(vidas == 0)
        {
            SceneManager.LoadScene("Pantalla de perdio");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            vidas -= 1;
        }
    }
}
