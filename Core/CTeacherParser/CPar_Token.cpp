#include "CPar_Token.h"

CPar_Symbol::CPar_Symbol()
{
	symbOwner	= "";
	symbID		= CPAR_SYMB_NONE;
	symbVal		= "";
}

CPar_Symbol::CPar_Symbol(std::string owner, TPar_SymbolID id, std::string val)
{
	symbOwner	= owner;
	symbID		= id;
	symbVal		= val;
}

CPar_Symbol::~CPar_Symbol()
{
	symbOwner	= "";
	symbID		= CPAR_SYMB_NONE;
	symbVal		= "";
}