using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 11;
	
	public Text guessed;
	public Text triesLeft;

	// Use this for initialization
	void StartGame () {
		max = 1000;
		min = 1;
		NextGuess();
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	void NextGuess () {
		guess = Random.Range(min,max+1);
		guessed.text = guess.ToString();
		maxGuessesAllowed-=1;
		triesLeft.text = maxGuessesAllowed.ToString();
		if(maxGuessesAllowed<=0){
			Application.LoadLevel("Win");
		}
	}
	
	void Start () {
		StartGame();
	}
	
	
}
