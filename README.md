# CTeachers
CTeacher Maker Tool

This project is special parser, for parsing files .tmf, to Daedalus.

# About project:
Project is new implementation of my old project from ~2019, CTeacherMaker. 
I lost all sources of old project, so I decited to rewrite for newbie scripters of Daedalus. 
Project inlcludes 3 main parts.

## Parser
CORE of project. Special parser for parsing new script files to output Daedalus scripts. 
With Special Symbols writing a teacher is easier than write it via original ZenGine Scripts.

For Example, original script file with learning only one attribute - strength.
```
INSTANCE DIA_NPC_TEACH(C_INFO)
{
  instance = NPC_INSTANCE;
  nr   = 999;
  description = "Teach me something!";
  permanent = true;
  info       = DIA_NPC_TEACH_INFO;
  condition  = DIA_NPC_TEACH_CONDITION;
}

func int DIA_NPC_TEACH_CONDITION()
{
  return true;
}

func void DIA_NPC_TEACH_INFO()
{
  Info_ClearChoices (DIA_NPC_TEACH);
  Info_AddChoices  (DIA_NPC_TEACH, DIA_NPC_TEACH_STR, "Strength + 5");
};

func void DIA_NPC_TEACH_STR()
{
  Info_ClearChoices (DIA_NPC_TEACH);
  B_Teach(self, ATR_STRENGTH, 5);
};
```

And parser language for, this same script
```
#INSTANCE = NPC_TEACH;
#NPC      = NPC_INSTANCE;
#NR       = 999;
#DESCRIPTION = "Learn me something!";

// Learn Strength, maximum of teacher is 100 points, and multiplier of cost is 5 * Config Variable in Daedalus
#TEACH_STR = 100, 5;
```

It's easier than writing, or copying and change values in original script. 
Of course you can write more teacher's in one file. 
You can run CParser.exe with `-h` param, for get more info about this tool.

## APP W.I.P
Special .NET app, for interface. Some user's don't know how to use params in .exe of CParser. So this application is for them.
Small friendly interface, with checkboxes to select with talent you NPC can teach. Of course, this tool have config of 'main' params like NPC, or INSTANCE.
It's the best tool for newbie scripter of Daedalus Teachers.


## DAEDALUS W.I.P
Package of special scripts for Daedalus. Necessary for using this tool.
Original, scripts have some stupid methods, where you can't easy config params in game (For Balance Example)
In this package you get special config file, where you can edit some interested values, like Multiplier Cost, Learning thresholds, Names, Languages and a lot of more.
