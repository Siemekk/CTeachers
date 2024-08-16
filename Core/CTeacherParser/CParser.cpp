#include "CParser.h"
#define CLog(x) (std::cout << x)

// Default type active parser
CParser* CParser::activeParser = NULL;

// Helper function extension of std::string
std::string findBetweenChars(std::string input, std::string begin, std::string end)
{
	size_t beginPos = input.find(begin.c_str());
	size_t endPos	= input.find(end.c_str());
	if (beginPos == std::string::npos || endPos == std::string::npos)
		return "";

	if (beginPos >= endPos)
		return "";

	size_t cutStart = beginPos + begin.length();
	size_t cutEnd = endPos - cutStart;
	return input.substr(cutStart, cutEnd);
}

CParser::CParser()
{
	currentInstance = "";
	arr_Symbols.clear();
	arr_Instances.clear();
}

CParser::~CParser()
{
	currentInstance = "";
	arr_Symbols.clear();
	arr_Instances.clear();
}

void CParser::ParseFile(const char* fileName)
{
	std::ifstream inputFile(fileName);

	if (inputFile.is_open())
	{
		std::string line;
		while (std::getline(inputFile, line)) {
			ParseLine(line);
		}
		inputFile.close();
	}
	else
	{
		std::cout << 
			"ERROR!" << std::endl << 
			"File: " << fileName << std::endl << 
			"Cannot be open!" << std::endl;
	}
}
// Read's data from line if finded "#"
bool CParser::FindLineSymbol(std::string input, std::string& output) 
{
	size_t findPos = input.find("#");
	size_t signPos = input.find('=');
	size_t endPos = input.find(";");

	// Nie znaleziono symbolu!   
	if (findPos == std::string::npos) {
		return false;
	}

	// Parser Error - # 2x in the same line
	if (findPos != input.rfind("#")) {
		CLog("[FindLineSymbol]: Two symbols at this same line!");
		return false;
	}

	// Parser Error - Missing data
	if (signPos == std::string::npos || endPos == std::string::npos) {
		CLog("[FindLineSymbol]: Missing data!, possible missing '=' or ';'");
		return false;
	}

	// Z³y ci¹g symbolu
	if (findPos > signPos || signPos > endPos) {
		CLog("[FindLineSymbol]: Invalid symbol construction!");
		return false;
	}
	if (input[signPos + 1] == ' ') signPos++;
	output = input.substr(signPos + 1, endPos - signPos - 1);
	return true;
}


TPar_SymbolID CParser::GetSymbolIDByString(std::string line)
{

	std::string str = findBetweenChars(line, "#", "=");

	str.erase(remove(str.begin(), str.end(), ' '), str.end());
	str.erase(remove(str.begin(), str.end(), '\t'), str.end());
	std::transform	(str.begin(), str.end(), str.begin(), ::toupper);
	if (str == "INSTANCE")			return CPAR_SYMB_INSTANCE;
	else if (str == "NPC")			return CPAR_SYMB_NPC;
	else if (str == "NR")			return CPAR_SYMB_NR;
	else if (str == "CONDITION")	return CPAR_SYMB_CONDITION;
	else if (str == "DESCRIPTION")	return CPAR_SYMB_DESCRIPTION;
	else if (str == "TEACH_STR")	return CPAR_SYMB_TEACH_STR;
	else if (str == "TEACH_DEX")	return CPAR_SYMB_TEACH_DEX;
	else if (str == "TEACH_HP")		return CPAR_SYMB_TEACH_HP;
	else if (str == "TEACH_MP")		return CPAR_SYMB_TEACH_MP;
	else if (str == "TEACH_1H")		return CPAR_SYMB_TEACH_1H;
	else if (str == "TEACH_2H")		return CPAR_SYMB_TEACH_2H;
	else if (str == "TEACH_BOW")	return CPAR_SYMB_TEACH_BOW;
	else if (str == "TEACH_CBOW")	return CPAR_SYMB_TEACH_CBOW;

	return CPAR_SYMB_NONE;
}
bool CParser::CheckInstanceExist(std::string val) 
{
	for (size_t i = 0; i < arr_Instances.size(); i++)
		if (arr_Instances[i].compare(val) == false)
			return true;
	return false;
}

void CParser::ParseLine(std::string line)
{
	if (line.find("#") != -1)
	{
		TPar_SymbolID newSymbol = GetSymbolIDByString(line);
		std::string symbolVal;
		if (FindLineSymbol(line, symbolVal) == true)
		{
			if (newSymbol == CPAR_SYMB_INSTANCE)
			{
				// Check instance is exist in stack
				// Important for output parsing methods
				if (!CheckInstanceExist(symbolVal))
					arr_Instances.push_back(symbolVal);
				
				currentInstance = symbolVal;
			}
			else if (newSymbol != CPAR_SYMB_NONE)
			{
				if (currentInstance.empty()) 
				{
					std::cout << "ERROR! INSTANCE IS EMPTY!" << std::endl;
					return;
				}

				CPar_Symbol* symbol = FindSymbol(newSymbol, currentInstance);
				if (symbol == nullptr)
				{
					symbol = new CPar_Symbol(currentInstance, newSymbol, symbolVal);
					arr_Symbols.push_back(symbol);
				}
				else
				{
					symbol->SetValue(symbolVal);
				}
			}
		}
	}
}

std::string CParser::SymbolIDToString(TPar_SymbolID s)
{
	switch (s)
	{
		case CPAR_SYMB_CONDITION:	return "CONDITION";
		case CPAR_SYMB_INSTANCE:	return "INSTANCE";
		case CPAR_SYMB_NPC:			return "NPC";
		case CPAR_SYMB_DESCRIPTION:	return "DESCRIPTION";
		case CPAR_SYMB_NR:			return "NR";
		case CPAR_SYMB_INFO:		return "INFO";
		case CPAR_SYMB_TEACH_STR:	return "TEACH_STR";
		case CPAR_SYMB_TEACH_DEX:	return "TEACH_DEX";
		case CPAR_SYMB_TEACH_HP:	return "TEACH_HP";
		case CPAR_SYMB_TEACH_MP:	return "TEACH_MP";
		case CPAR_SYMB_TEACH_1H:	return "TEACH_1H";
		case CPAR_SYMB_TEACH_2H:	return "TEACH_2H";
		case CPAR_SYMB_TEACH_BOW:	return "TEACH_BOW";
		case CPAR_SYMB_TEACH_CBOW:	return "TEACH_CBOW";
	}
	return "NONE";
}

void CParser::SaveFile(const char* savePath)
{
	std::ofstream* output = new std::ofstream	(savePath, std::ios::trunc);
	if (!output->is_open()) return; 

	for (size_t i = 0; i < arr_Instances.size(); i++)
	{
		std::vector<CPar_Symbol*> arr_InstanceSymbols;
		std::string instance = "";

		for (size_t j = 0; j < arr_Symbols.size(); j++)
		{
			instance				= arr_Instances[i];
			CPar_Symbol* symbol		= arr_Symbols[j];
			if (instance.compare(symbol->GetOwner()) == false)
			{
				// Stack Tree
				std::cout << instance << "." << SymbolIDToString(symbol->GetID()) << "=" << symbol->GetValue() << ";" << std::endl;
				arr_InstanceSymbols.push_back(symbol);
			}
		}

		BuildDialog(instance, arr_InstanceSymbols, output);
		arr_InstanceSymbols.clear();
		std::cout << "-----------------------------" << std::endl;
	}
	output->close();
	delete output;
	output = nullptr;
}

CPar_Symbol* CParser::GetSymbolByID(std::vector<CPar_Symbol*> inputArray, TPar_SymbolID id)
{
	for (size_t i = 0; i < inputArray.size(); i++)
		if (inputArray[i]->GetID() == id)
			return inputArray[i];
	return nullptr;
}

void CParser::PopSkills(std::vector<CPar_Symbol*> m_arrSymbols, std::ofstream* out)
{
	for (size_t i = m_arrSymbols.size() - 1; i > 0; i--)
	{
		CPar_Symbol* symbol		= m_arrSymbols[i];
		TPar_SymbolID symbID	= symbol->GetID();
		if (symbID >= CPAR_SYMB_TEACH_STR && symbID <= CPAR_SYMB_TEACH_CBOW)
			*out << "\tNpc_BuildTeach(" << symbol->GetOwner() << ", " << SymbolIDToString(symbID) << ", " << symbol->GetValue() << "); \n";
	}
}

void  CParser::BuildDialog(std::string instance, std::vector<CPar_Symbol*> m_arrSymbols, std::ofstream* out)
{
	if (m_arrSymbols.size() == 0) {
		std::cout << "NO SYMBOLS IN THIS INSTANCE!\nNO PARSE THIS INST!\n";
		return;
	}
	CPar_Symbol* symbol = nullptr;
	// Build dialogue instance
	*out << "INSTANCE " << instance << " (C_INFO)\n{\n";

	
	// NPC
	symbol = GetSymbolByID(m_arrSymbols, CPAR_SYMB_NPC);
	if (symbol)	*out << "\tnpc = " << symbol->GetValue() << ";\n";

	// NR
	symbol = GetSymbolByID(m_arrSymbols, CPAR_SYMB_NR);
	if (symbol)	*out << "\tnr = " << symbol->GetValue() << ";\n";

	//  DESCRIPTION
	symbol = GetSymbolByID(m_arrSymbols, CPAR_SYMB_DESCRIPTION);
	if (symbol)	*out << "\tdesription = " << symbol->GetValue() << ";\n";

	// Other stuff not important fot this parser:
	*out << "\tpermanent = true;\n";
	*out << "\tcondition = " << instance << "_CONDITION;\n";
	*out << "\tinfo = " << instance << "_INFO;\n";
	*out << "};\n\n";


	// TIME to build condition
	*out << "FUNC INT " << instance << "_CONDITION()\n{\n";
	symbol = GetSymbolByID(m_arrSymbols, CPAR_SYMB_CONDITION);
	if (symbol)
		*out << "\tif(" << symbol->GetValue() << ") {\n\t\treturn true;\n\t};\n\treturn false;\n";
	else
		*out << "\treturn true;\n";
	*out << "};\n\n";

	*out << "FUNC VOID " << instance << "_INFO()\n{\n";
	*out << "\tAI_OUTPUT(self, other, \"VOICE_HERO_LEARN_ME\"); // Ucz mnie!\n"; 
	*out << "\tInfo_ClearChoices(" << instance << ");\n";

	// First step - add return option:
	*out << "\tInfo_AddChoice(" << instance << ", DIAG_BACK, DIAG_BACK_FUNC);\n";

	//Zengine dialog parser have lifo list
	// so it's necessary to get symbols from last to first
	// to jest podyktowane standardem w jakim zawsze pisze sie dialogi...
	
	// Pop learning skills:
	PopSkills(m_arrSymbols, out);

	// End Info Block
	*out << "};\n\n";
}


CPar_Symbol* CParser::FindSymbol(TPar_SymbolID id, std::string instance) 
{
	for (size_t i = 0; i < arr_Symbols.size(); i++) 
	{
		CPar_Symbol* symbol = arr_Symbols[i];
		if (symbol->GetID() == id && (instance.compare(symbol->GetOwner()) == false))
			return symbol;
	}
	return nullptr;
}

CParser* CParser::CreateParser() {
	
	if (activeParser == nullptr)
		activeParser = new CParser();
	return activeParser;
}

void CParser::Destroy()
{
	if (activeParser) delete activeParser;
	activeParser = nullptr;
}
