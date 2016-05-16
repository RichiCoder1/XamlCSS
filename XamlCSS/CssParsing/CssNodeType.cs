﻿namespace XamlCSS.CssParsing
{
	public enum CssNodeType
	{
		Unknown = 0,
		Selectors = 1,
		Selector = 2,
		Body = 3,
		Line = 4,
		Key = 5,
		Value = 6,
		Document = 7,
		NamespaceDeclaration = 8,
		NamespaceKeyword = 9,
		NamespaceAlias = 10,
		NamespaceValue = 11,
		StyleRule = 12,
		StyleDeclarationBlock = 13,
		StyleDeclaration = 14,
		SelectorFragment = 15
	}
}
