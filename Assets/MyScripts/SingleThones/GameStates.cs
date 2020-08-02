using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class  GameStates  
{ 
    public static string main_alphabet = "А,Б,В,Г,Д,Е,Ё,Ж,З,И,Й,К,Л,М,Н,О,П,Р,С,Т,У,Ф,Ч,Ц,Ч,Ш,Щ,Ъ,Ы,Ь,Э,Ю,Я";
    public static string missons = "МАМА,ПАПА,КУСТ,МОСТ,КРУЖКА";
    public static string letterToGuess = "А";
    public static int missionWrongTaps = 0;
    public static int turn = 0;
    public static float  maximumMood = 3; 
    public static float  mood = maximumMood;
    internal static bool studyModeIsOn = true;

    public static int level = 1;

    public static bool hardMode = true;
    public static float gravityOfLetters = 0.2f;


    public static string letterToStudy ="А";
    public  static int studyModeNumOfGuesses =0 ;
    public static int studyModeMaximumNumOfGuesses = 4;
    public static string currentMission = "МАМА";
    public  static bool isMissionModeOn = true; 
    public  static  List<string> missionModeGuesedLetter = new List<string>();
    public static int numOfMissionModeGuesedLetter = 0;
    /*
<<<<<<< HEAD

    public static string currentAlphabet = "RUS";
    public static string [] availaibleAlphabets = { "RUS", "AVR" };
    public static void SetAvarianAlphabetAndMissions()
    {
        main_alphabet = "А,Б,В,Г,Гъ,Гь,ГI,Д,Е,Ё,Ж,З,И,Й,К,КI,Къ,Кь,Л,Лъ,М,Н,О,П,Р,С,Т,ТI,У,Ф,Ч,ЧI,Ц,X,XI,Xь,Xъ,ЦI,Ш,Щ,Ъ,Ы,Ь,Э,Ю,Я";
        main_missons = "ЭБЕЛ,ЭМЕН,ГЪВЕТI,КЬО";
        currentAlphabet = "AVR";
    }
    public static void SetRussianAlphabetAndMissions()
    {
        main_alphabet = "А,Б,В,Г,Д,Е,Ё,Ж,З,И,Й,К,Л,М,Н,О,П,Р,С,Т,У,Ф,X,Ч,Ц,Ш,Щ,Ъ,Ы,Ь,Э,Ю,Я";
        main_missons = "МАМА,ПАПА,КУСТ,МОСТ";
        currentAlphabet = "RUS";
    }
=======
>>>>>>> parent of 225a963... 13
*/
    public static void SetLetterToGuess()
    {
        letterToGuess = main_alphabet.Split(',')[Random.Range(0 + GameStates.turn, 3 + GameStates.turn)];
    }
    public static void nextTurn()
    {
        turn++; 
    }
}
