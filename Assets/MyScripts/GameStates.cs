using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class  GameStates  
{ 
    public static string russianAlphabet = "а,б,в,г,д,е,ё,ж,з,и,й,к,л,м,н,о,п,р,с,т,у,ф,х,ц,ч,ш,щ,ъ,ы,ь,э,ю,я";
    public static string letterToGuess = "";
    public static int score = 0;
    public static int turn = 0;
    public static float  maximumMood = 3; 
    public static float  mood = maximumMood;
    internal static bool studyModeIsOn = true;

    public static bool hardMode = true;
    public static float gravityOfLetters = 1;


    public static string letterToStudy;
    public  static int studyModeNumOfGuesses =0 ;
    internal static int studyModeMaximumNumOfGuesses = 4;
   

    public static void SetLetterToGuess()
    {
        letterToGuess = russianAlphabet.Split(',')[Random.Range(0 + GameStates.turn, 3 + GameStates.turn)];
    }
    public static void nextTurn()
    {
        turn++; 
    }
}
