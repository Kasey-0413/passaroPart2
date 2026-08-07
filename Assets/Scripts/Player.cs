using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float forcaVoar = 3f;
    Rigidbody2D rig;
    InputPlayer controles;

    public TextMeshProUGUI txtPontos;
    public TextMeshProUGUI txtHighScore;
    int pontos = 0;
    public GameObject painelIsadora;
    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        controles = new InputPlayer();
    }
    void OnEnable()
    {
        controles.Enable();
    }
    void OnDisable()
    {
        controles.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controles.Player.voar.WasPressedThisFrame())
        {
            rig.linearVelocityY = forcaVoar;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ponto"))
        {
            pontos++;
            txtPontos.text = pontos.ToString();

            PlayerPrefs.SetInt("HighScore", pontos);
            PlayerPrefs.GetInt("HighScore");
        }
    }
   void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("isadora"))
        {
            painelIsadora.SetActive(true);
            Time.timeScale = 0f;

            if(pontos > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", pontos);
            }
            txtHighScore.text = "HighScore" + PlayerPrefs.GetInt("HighScore").ToString();
        }
    }
    public void ReiniciarJogo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
