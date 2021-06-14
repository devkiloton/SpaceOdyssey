using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Generator : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private GameObject prefabInimigo;
    [SerializeField]
    private Scores scores;
    [SerializeField]
    private float time;
    [SerializeField]
    private float raio;

    private void Start()
    {
        InvokeRepeating("Instantiate", 0f, time);
    }
    private void Instantiate()
    {
        var enemy = GameObject.Instantiate(this.prefabInimigo);
        this.DefinirPosicaoInimigo(enemy);
        enemy.GetComponent<Follow>().SetTarget(target);
        enemy.GetComponent<Scoreable>().SetScores(this.scores);

    }

    private void DefinirPosicaoInimigo(GameObject enemy)
    {
        var posicaoAleatoria = new Vector3(
                        Random.Range(-this.raio, this.raio),
                        Random.Range(-this.raio, this.raio),
                        0);

        var posicaoInimigo = this.transform.position + posicaoAleatoria;
        enemy.transform.position = posicaoInimigo;
    }
}
