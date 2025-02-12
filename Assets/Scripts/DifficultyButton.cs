using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private GameManager gameManager;
    private Button button;

    public int difficulty;
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button.onClick.AddListener(SetDifficulty); //pays attention to when an event happens
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + "was clicked");
        gameManager.StartGame(difficulty);
    }
}
