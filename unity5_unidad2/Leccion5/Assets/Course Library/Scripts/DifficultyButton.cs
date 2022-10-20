//librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    // Buton 
    private Button button;
    // Manejador del juego
    private GameManager gameManager;
    // Dificultad
    public int difficulty;

    // Al comienzo del juego apareceran los botones y se tomara la dicultad 
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void Update()
    {
        
    }
 
    // Funcion que define la dificultad
    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " Fue presionado");
        gameManager.StartGame(difficulty);
    }
}