using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public void ChooseDifficulty()
	{
		SceneManager.LoadScene("Difficulty");
	}

	public void Easy()
	{
		SceneManager.LoadScene("Easy");
	}

	public void Medium()
	{
		SceneManager.LoadScene("Medium");
	}

	public void Hard()
	{
		SceneManager.LoadScene("Hard");
	}
}