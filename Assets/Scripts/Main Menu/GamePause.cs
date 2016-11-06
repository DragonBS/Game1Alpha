using UnityEngine;
using System.Collections;

public class GamePause : MonoBehaviour {

	public GameObject inGameMenu;
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown("escape"))
		{
			if (Time.timeScale == 0)
			{
				Time.timeScale = 1;
				inGameMenu.SetActive(false);
			}

			else
			{
				Time.timeScale = 0;
				inGameMenu.SetActive(true);
			}
		} 
	}
}
