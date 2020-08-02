using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class  GameStates  
{ 
    public static string main_alphabet = "А,Б,В,Г,Д,Е,Ё,Ж,З,И,Й,К,Л,М,Н,О,П,Р,С,Т,У,Ф,Ч,Ц,Ч,Ш,Щ,Ъ,Ы,Ь,Э,Ю,Я";
    public static string main_missons = "МАМА,ПАПА,КУСТ,МОСТ";
    public static string letterToGuess = "А";
    public static int missionWrongTaps = 0;
    public static int turn = 0;
    public static float  maximumMood = 3; 
    public static float  mood = maximumMood;
    internal static bool studyModeIsOn = true;

    public static int level = 1;

    public static bool hardMode = true;
    public static float gravityOfLetters = 1;


    public static string letterToStudy ="А";
    public  static int studyModeNumOfGuesses =0 ;
    public static int studyModeMaximumNumOfGuesses = 4;
    public static string currentMission = "ИГОРЬ";
    public static int currentMissionLetterIndex = 0;
    public  static bool isMissionModeOn = true; 
    public  static  List<string> missionModeGuesedLetter = new List<string>();
    public static int numOfMissionModeGuesedLetter = 0;


    public static void SetAvarianAlphabetAndMissions()
    {
        main_alphabet = "А,Б,В,Г,Д,Е,Ё,Ж,З,И,Й,К,Л,М,Н,О,П,Р,С,Т,У,Ф,Ч,Ц,Ч,Ш,Щ,Ъ,Ы,Ь,Э,Ю,Я,I";
        main_missons = "ЭБЕЛ,ЭМЕН,ГЪВЕТI,КЬО";
    }
    public static void SetRussianAlphabetAndMissions()
    {
        main_alphabet = "А,Б,В,Г,Д,Е,Ё,Ж,З,И,Й,К,Л,М,Н,О,П,Р,С,Т,У,Ф,Ч,Ц,Ч,Ш,Щ,Ъ,Ы,Ь,Э,Ю,Я";
        main_missons = "МАМА,ПАПА,КУСТ,МОСТ";
    }

    public static void SetLetterToGuess()
    {
        letterToGuess = main_alphabet.Split(',')[Random.Range(0 + GameStates.turn, 3 + GameStates.turn)];
    }
    public static void nextTurn()
    {
        turn++; 
    }
}
