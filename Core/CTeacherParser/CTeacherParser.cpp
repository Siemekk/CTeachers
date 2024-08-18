// CTeacherParser.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
#include <string>
#include "CParser.h"
const char* inputFile;
const char* outputFile;

void parseArgv(int argc, char* argv[], int i)
{
    std::string string_arg(argv[i]);
    std::cout << string_arg << std::endl;

    if (string_arg.compare("-h") == false)
    {
        std::cout
        << "This app is parser for special teacher script." << std::endl
        << "It's convert custom tokens to full dialogue file for ZenGine scripts parser (Gothic I & II engine)"  << std::endl
        << "This is only, parser w/o any interface - interface will be writen in C#." << std::endl
        << "This app is only used to fast convert .tmf for C# interface app." << std::endl << std::endl;

        std::cout << "[APP Params]:" << std::endl;
        std::cout << "-f \tPath to .tmf file (This file will be parsed)" << std::endl;
        std::cout << "-s \tSaves file at selected path." << std::endl;
     
        std::cout << "-h \tDisplay help info for app." << std::endl;
        std::cout << "-* any info add here... Maybe parse .d to .tmp?" << std::endl; 
    }

    if (string_arg.compare("-f") == false)
    {
        if ((i + 1) >= argc) {
            std::cout << "Unknown param for -f! Type -h if you want get more info about app!"
                << std::endl;
            return; 
        }

        std::cout << "Starting parsing file -> " << argv[i + 1];
        inputFile = argv[i + 1];
    }

    if (string_arg.compare("-s") == false)
    {
        if ((i + 1) >= argc) {
            std::cout << "Unknown param for -s! Type -h if you want get more info about app!"
                << std::endl;
            return;
        }

        std::cout << "Saving to file -> " << argv[i + 1];
        outputFile = argv[i + 1];
    }
}

int main(int argc, char* argv[])
{

    for (int i = 1; i < argc; i++)
        parseArgv(argc, argv, i);
    

    if (std::string(inputFile).empty()) 
    {
        std::cout << "Input file path is empty!\n";
        return EXIT_FAILURE; 
    }

    if (std::string(outputFile).empty()) //Maybe add _out for inputFile?
    {
        std::cout << "Output file path is empty!\n";
        return EXIT_FAILURE;
    }
    
    CParser* par = CParser::CreateParser();
    
    par->ParseFile  (inputFile);
    par->SaveFile   (outputFile);
    
    par->Destroy();
    par = nullptr;
}
