using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	

    public void StartGame(string levelName)
    {

        Debug.Log("Scence load request" + levelName);

        Application.LoadLevel(levelName);



    }




    public void ReStartGame(string levelName)
    {

		Debug.Log("Scence load request" + levelName);


        Application.LoadLevel(levelName);



    }



    public void QuitGame()
    {



        Application.Quit();



    }













}
