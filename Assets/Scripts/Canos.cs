using UnityEngine;
public class Canos : MonoBehaviour
{
    public float velocidade = 3f;
    public float destruir = -10f;
    void Start()
    {
    }
    void Update()
    {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);
        if (transform.position.x < destruir)
        {
            Destroy(gameObject);
        }
    }
}