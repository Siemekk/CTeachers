#ifndef __PARSER__
#define __PARSER__
#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include "CPar_Token.h"

class CParser
{
private:
	static CParser* activeParser;										// Global pointer of current parser
	std::string currentInstance;										// Small helper variable, used to switching instances on parse process
	CParser		();														// Constructor - Don't use! Use static method 'CreateParser'
	~CParser	();														// Destructor  - Don't use! Use 'Destroy()' method
	std::vector<CPar_Symbol*>	arr_Symbols;							// Dynamic array of CParSymbols getted from first parsing file
	std::vector<std::string>	arr_Instances;							// Dynamic array of CParSymbol.INSTANCE, used for override params in instances

#pragma region Parser
	std::string SymbolIDToString		(TPar_SymbolID);				// Convert String to TParSymb_ID
	TPar_SymbolID GetSymbolIDByString	(std::string);					// Convert TParSymb_ID to String
	bool  CheckInstanceExist			(std::string);					// Check is instance in arr_Instances
	CPar_Symbol* FindSymbol				(TPar_SymbolID, std::string);	// Finds symbol via ID in arr_Symbols
	bool FindLineSymbol					(std::string, std::string&);	// Try to find symbol in specific line
	void ParseLine						(std::string);					// Parse line
#pragma endregion

#pragma region Builder
	CPar_Symbol* GetSymbolByID	(std::vector<CPar_Symbol*>, TPar_SymbolID);					// Find symbol with ID, in arr_symbols with specific instance
	void PopSkills				(std::vector<CPar_Symbol*>, std::ofstream*);				// Pop skill function, for build methods with learning skill in .d scripts
	void BuildDialog			(std::string, std::vector<CPar_Symbol*>, std::ofstream*);	// Main method of builder
#pragma endregion

public: 
	static CParser* CreateParser();		// Public Constructor of parser
	void ParseFile	(const char*);		// Open file, and parse it to Symbol arrays
	void SaveFile	(const char*);		// Parse file from Symbol arrays, and save it to output file
	void Destroy	();					// Public destructor of parser
};

#endif