using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnBehavior : MonoBehaviour
{
	private Button btn;

	private void Start()
	{
		btn = GetComponent<Button>();
		btn.onClick.AddListener(Click);
	}

	public void Click()
	{
		// 点击退出游戏
		if (btn.name == "btnExit")
		{
			Debug.Log("Game Exit");
			Application.Quit();
		}

		// 点击开始游戏
		if (btn.name == "btnNewGame")
		{
			Debug.Log("Start Game");
			int level1Index = 1;
			SceneManager.LoadScene(level1Index);
		}
	}
}
