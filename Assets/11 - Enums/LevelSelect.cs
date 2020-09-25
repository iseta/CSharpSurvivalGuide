using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public enum Difficulty
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    public Difficulty selectedDifficulty;

    private void Start()
    {
        SceneManager.LoadScene((int)selectedDifficulty);
    }
}
