using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public GameObject StrikeCanvas;

    public GameObject Quilles;
    public GameObject Balle;
    public Transform BalleSpawnPoint;
    public Transform QuillesSpawnPoint;

    private int score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        score=0;
        StrikeCanvas.SetActive(false);
        Instantiate(Quilles, QuillesSpawnPoint.position, QuillesSpawnPoint.rotation);
        Instantiate(Balle, BalleSpawnPoint.position, BalleSpawnPoint.rotation);

    }

    public void SpawnBowling(){
        if (Quilles && Balle != null)
        {
            Destroy(GameObject.FindWithTag("Quille"));
            Destroy(GameObject.FindWithTag("Balle"));
            score=0;
            StrikeCanvas.SetActive(false);
            Instantiate(Quilles, QuillesSpawnPoint.position, QuillesSpawnPoint.rotation);
            Instantiate(Balle, BalleSpawnPoint.position, BalleSpawnPoint.rotation);
        }

    }

    public void AjouterPoints()
    {
        score++;
        Debug.Log("Score: " + score);
        if (score>9){
            StrikeCanvas.SetActive(true);
            StartCoroutine(StrikeDelay());
        }
    }

    IEnumerator StrikeDelay()
{
    yield return new WaitForSeconds(.3f);
    SpawnBowling();
}

}
