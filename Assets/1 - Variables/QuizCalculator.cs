using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public int gradesLength;
    public float[] grades;
    private float average;

    // Start is called before the first frame update
    void Start()
    {
        grades = new float[gradesLength];
        for (int i = 0; i < gradesLength; i++)
        {
            grades[i] = Random.Range(0.0f, 10.0f);
            average += grades[i];
        }
        average = average / gradesLength;
        Debug.Log("Your average grade in scores is: "+average);
    }
}
