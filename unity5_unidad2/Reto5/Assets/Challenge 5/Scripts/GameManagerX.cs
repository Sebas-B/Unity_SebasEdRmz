using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerX : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI gameOverText;
    public GameObject titleScreen;
    public Button restartButton; 

    public List<GameObject> targetPrefabs;

    private int score;
    public float timeValue;
    private float spawnRate = 1.5f;
    public bool isGameActive;

    private float spaceBetweenSquares = 2.5f; 
    private float minValueX = -3.75f; //  el valor x del centro del cuadrado más a la izquierda
    private float minValueY = -3.75f; //  el valor y del centro del cuadrado más bajo
    
    // Inicia el juego, elimina la pantalla de título, restablece la puntuación y ajusta el spawnRate en función del botón de dificultad pulsado
    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        titleScreen.SetActive(false);
        timeValue = 60;
    }

    // Mientras el juego está activo genera un objetivo aleatorio
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targetPrefabs.Count);

            if (isGameActive)
            {
                Instantiate(targetPrefabs[index], RandomSpawnPosition(), targetPrefabs[index].transform.rotation);
            }
            
        }
    }

    // Generar una posición de aparición aleatoria basada en un índice aleatorio de 0 a 3
    Vector3 RandomSpawnPosition()
    {
        float spawnPosX = minValueX + (RandomSquareIndex() * spaceBetweenSquares);
        float spawnPosY = minValueY + (RandomSquareIndex() * spaceBetweenSquares);

        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, 0);
        return spawnPosition;

    }

    // Genera un índice de cuadrado aleatorio de 0 a 3, que determina en qué cuadrado aparecerá el objetivo
    int RandomSquareIndex()
    {
        return Random.Range(0, 4);
    }

    // Actualizar la puntuación con el valor del objetivo pulsado
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "score " + score;
    }

    // Detener el juego, hacer que aparezca el texto del juego y el botón de reinicio
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    // Reiniciar el juego recargando la escena
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void TimeLeft(){
        timeValue -= Time.deltaTime;
        timeText.text = "Tiempo "+ Mathf.Round(timeValue);
    }

    public void Update () 
    {
        if(isGameActive == true)
        {
            TimeLeft();
        }    
        if(timeValue < 0) 
        {
            GameOver();    
        }
    }

}
