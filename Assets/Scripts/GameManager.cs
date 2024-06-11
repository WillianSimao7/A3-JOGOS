using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject bolinha;
    public Text Score1, Score2;
    public static int score1 = 0, score2 = 0;
    private static GameManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        score1 = 0;
        score2 = 0;
        AtualizarPontuacao();
        SpawnBola();
    }

    public static void SpawnBola()
    {
        if (instance != null && instance.bolinha != null)
        {
            GameObject instanceBola = Instantiate(instance.bolinha);
            Bola bolaEmJogo = instanceBola.GetComponent<Bola>();
            if (bolaEmJogo != null)
            {
                bolaEmJogo.transform.position = Vector3.zero;
            }
            else
            {
                Debug.LogError("O prefab da bolinha não tem o componente Bola.");
            }
        }
        else
        {
            Debug.LogError("Instance ou bolinha é nulo!");
        }
    }

    public static void AtualizarPontuacao()
    {
        if (instance != null && instance.Score1 != null && instance.Score2 != null)
        {
            instance.Score1.text = score1.ToString();
            instance.Score2.text = score2.ToString();
        }
        else
        {
            Debug.LogError("Instance ou Texts são nulos!");
        }
    }
}
