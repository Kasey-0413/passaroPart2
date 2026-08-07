using UnityEngine;

public class fundoInfinito : MonoBehaviour
{
    public float velocidade = 1f;
    public Transform proximoFundo;

    float larguraDoSprite;

    SpriteRenderer renderizador;

    void Awake()
    {
        renderizador = GetComponent<SpriteRenderer>();

        larguraDoSprite = renderizador.bounds.size.x;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;
        if (transform.position.x <= - larguraDoSprite)
        {
            float novaPosicaoX = proximoFundo.position.x + larguraDoSprite;

            transform.position = new Vector3(novaPosicaoX, transform.position.y, transform.position.z);
        }

    }
}
