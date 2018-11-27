using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestruirContato : MonoBehaviour {
	public GameObject explosaoAsteroide;
	public GameObject explosaoJogador;
	private Jogo jogo;
    public int vida;
    public Text pontuacao;


	void Start () {
        pontuacao = GameObject.FindGameObjectWithTag("pont").GetComponent<Text>();
        jogo = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Jogo> ();
       
	}

    void OnTriggerEnter(Collider outroCollider) {
        if (outroCollider.CompareTag("Limite"))
        {
            return;
        }
        else if (outroCollider.CompareTag("inimigo"))
        {
            return;
        }
        else
        {
            vida--;
            Instantiate(explosaoAsteroide, outroCollider.transform.position, outroCollider.transform.rotation);
            if (outroCollider.CompareTag("Player"))
            {
                Destroy(outroCollider.gameObject);
                jogo.FinalizarJogo();
                Instantiate(explosaoJogador, outroCollider.transform.position, outroCollider.transform.rotation);

            }
            if (vida == 0)
            {
                Destroy(this.gameObject);
                Instantiate(explosaoAsteroide, transform.position, transform.rotation);
                Pontuacao.adiciona();
                pontuacao.text = "Pontos:" + Pontuacao.pegaPontos();

            }

            /*
            if (outroCollider.CompareTag("Chefao"))
            {

                Instantiate(explosaoAsteroide, outroCollider.transform.position, outroCollider.transform.rotation);

            }
            */
            Destroy(outroCollider.gameObject);

        }
        
        }
    }
	


