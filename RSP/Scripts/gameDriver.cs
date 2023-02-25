using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameDriver : MonoBehaviour
{
    [SerializeField] int playerChoice;
    public Sprite[] sprites = new Sprite[6];
    public Image botImage;
    public Image botText;
    public GameObject playerScoreText;
    public GameObject botScoreText;
    int playerScore = 0;
    int botScore = 0;
    public void rockChoosed()
    {
        playerChoice = 1;
        botChooice(playerChoice);
    }
    public void sciChoosed()
    {
        playerChoice = 2;
        botChooice(playerChoice);
    }
    public void paperhoosed()
    {
        playerChoice = 3;
        botChooice(playerChoice);
    }
    public void botChooice(int _playerChoice)
    {
        int botChoice = Random.Range(1, 4);
        if (botChoice == 1)
        {
            botImage.sprite = sprites[0];
            botText.sprite = sprites[1];
        }
        else if (botChoice == 2)
        {
            botImage.sprite = sprites[2];
            botText.sprite = sprites[3];
        }
        else if (botChoice == 3)
        {
            botImage.sprite = sprites[4];
            botText.sprite = sprites[5];
        }
        checkWinner(_playerChoice, botChoice);
    }
    public void checkWinner(int _playerChoice, int _botChoice)
    {
        if (_playerChoice == 1)
        {
            if (_botChoice == 2)
            {
                playerScore++;
                playerScoreText.GetComponent<Text>().text = playerScore.ToString();
            }
            else if (_botChoice == 3)
            {
                botScore++;
                botScoreText.GetComponent<Text>().text = botScore.ToString();
            }
        }
        else if (_playerChoice == 2)
        {
            if (_botChoice == 1)
            {
                botScore++;
                botScoreText.GetComponent<Text>().text = botScore.ToString();
            }
            else if (_botChoice == 3)
            {
                playerScore++;
                playerScoreText.GetComponent<Text>().text = playerScore.ToString();
            }
        }
        else if (_playerChoice == 3)
        {
            if (_botChoice == 1)
            {
                playerScore++;
                playerScoreText.GetComponent<Text>().text = playerScore.ToString();
            }
            else if (_botChoice == 2)
            {
                botScore++;
                botScoreText.GetComponent<Text>().text = botScore.ToString();
            }
        }
    }
}
