using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionArea : MonoBehaviour
{
    public Text txtScore;
    public int score;
    public int MaxScore = 2500;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        score += alimento.valorAlimentario;
        if (score < MaxScore)
        {
            txtScore.text = score.ToString();
            Destroy(collision.gameObject);
        }
        else
        {
            txtScore.text = "Ganaste!";
        }

    }
}