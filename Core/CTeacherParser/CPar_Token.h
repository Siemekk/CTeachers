#ifndef  __TOKENS__
#define  __TOKENS__
#include <string>
enum TPar_SymbolID 
{
	CPAR_SYMB_NONE = 0,
	CPAR_SYMB_INSTANCE,
	CPAR_SYMB_NPC,
	CPAR_SYMB_DESCRIPTION,
	CPAR_SYMB_NR,
	CPAR_SYMB_CONDITION,
	CPAR_SYMB_INFO,
	CPAR_SYMB_TEACH_STR,
	CPAR_SYMB_TEACH_DEX,
	CPAR_SYMB_TEACH_HP,
	CPAR_SYMB_TEACH_MP,
	CPAR_SYMB_TEACH_1H,
	CPAR_SYMB_TEACH_2H,
	CPAR_SYMB_TEACH_BOW,
	CPAR_SYMB_TEACH_CBOW
};

class CPar_Symbol
{
private:
	std::string		symbOwner; // instanceID
	TPar_SymbolID	symbID;
	std::string		symbVal;
public:
	CPar_Symbol();
	CPar_Symbol(std::string, TPar_SymbolID, std::string);
	~CPar_Symbol();
	
	std::string		GetOwner()	{ return symbOwner;	}
	std::string		GetValue()	{ return symbVal;		}
	TPar_SymbolID	GetID()		{ return symbID;		}

	void			SetValue(std::string val) { symbVal = val; };
};

#endif // ! __TOKENS__
