using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour {

	public Canvas storyMenu;
	public Canvas controlsMenu;
	public Canvas quitMenu;

	public Button storyText;
	public Button controlsText;
	public Button quitText;

	// Use this for initialization
	void Start () {
		storyMenu = storyMenu.GetComponent<Canvas>();
		controlsMenu = controlsMenu.GetComponent<Canvas>();
		quitMenu = quitMenu.GetComponent<Canvas>();

		storyText = storyText.GetComponent<Button>();
		controlsText = controlsText.GetComponent<Button>();
		quitText = quitText.GetComponent<Button>();

		storyMenu.enabled = false;
		controlsMenu.enabled = false;
		quitMenu.enabled = false;
	}

	public void storyPress() {
		storyMenu.enabled = true;
		controlsText.enabled = false;
		quitText.enabled = false;
	}

	public void controlsPress() {
		controlsMenu.enabled = true;
		storyText.enabled = false;
		quitText.enabled = false;
	}

	public void quitPress() {
		quitMenu.enabled = true;
		storyText.enabled = false;
		controlsText.enabled = false;
	}

	//for exit
	public void exitNoPress() {
		quitMenu.enabled = false;
		storyText.enabled = true;
		controlsText.enabled = true;
		quitText.enabled = true;
	}

	//for exit
	public void quitGame() {
		Application.Quit ();
	}

	public void storyContPress() {
		storyMenu.enabled = false;
		controlsText.enabled = true;
		quitText.enabled = true;
	}

	public void controlsContPress() {
		controlsMenu.enabled = false;
		storyText.enabled = true;
		quitText.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
