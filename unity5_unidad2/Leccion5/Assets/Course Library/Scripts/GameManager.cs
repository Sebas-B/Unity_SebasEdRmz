//Librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Velocidad en la que aparecen los objetos
    private float spawnRate = 1.0f;
    //Puntaje
    private int score;
    //Array con los objetos que se veran en pantalla
    public List<GameObject> targets;
    //Texto que acompaña al puntaje
    public TextMeshProUGUI scoreText;
    //Texto de juego terminado
    public TextMeshProUGUI gameOverText;
    //Verifica si el juego esta transcurriendo
    public bool isGameActive;
    //Boton de reinicio
    public Button restartButton;
    //Elementos que se presentan al iniciar el juego 
    public GameObject titleScreen;

    void Start(){ }
    
    //Funcion que comienza el juego
    public void StartGame(int difficulty){
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        spawnRate = spawnRate / difficulty;
    }

    void Update()
    {

    }

    // Funcion que indica que el juego termino
    public void GameOver () 
    {
        gameOverText.gameObject.SetActive(true);    
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    // Funcion que hace aparecer a los objetos
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    // Funcion que actualiza el puntaje del jugador
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    // Funcion que reinicia el juego
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
