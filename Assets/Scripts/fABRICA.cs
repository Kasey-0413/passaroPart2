using UnityEngine;
public class Spawn : MonoBehaviour
{
    public GameObject canos;
    public float intervalo = 2f;
    public float alturaMin = -1f;
    public float alturaMax = 1f;
    void criar()
    {
        float altura = Random.Range(alturaMin, alturaMax);
        Instantiate(canos,
        new Vector3(transform.position.x, altura, 0),
        Quaternion.identity);
    }
    void Start()
    {
        InvokeRepeating("criar", 0f, intervalo);
    }
    void Update()
    {
    }
}
