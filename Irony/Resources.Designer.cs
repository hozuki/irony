﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Irony {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Irony.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Nn 的本地化字符串。
        /// </summary>
        internal static string ConsoleNoChars {
            get {
                return ResourceManager.GetString("ConsoleNoChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Yy 的本地化字符串。
        /// </summary>
        internal static string ConsoleYesChars {
            get {
                return ResourceManager.GetString("ConsoleYesChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Ambiguous grammar, unresolvable reduce-reduce conflicts. State {0}, lookaheads [{1}] 的本地化字符串。
        /// </summary>
        internal static string ErrAmbigGrammarRR {
            get {
                return ResourceManager.GetString("ErrAmbigGrammarRR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Ambiguous grammar, unresolvable shift-reduce conflicts. State {0}, lookaheads [{1}] 的本地化字符串。
        /// </summary>
        internal static string ErrAmbigGrammarSR {
            get {
                return ResourceManager.GetString("ErrAmbigGrammarSR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Argument list not found in the stack. Expected: ValueList, found: {0}. 的本地化字符串。
        /// </summary>
        internal static string ErrArgListNotFound {
            get {
                return ResourceManager.GetString("ErrArgListNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid operation, attempt to assign to a constant or literal value. 的本地化字符串。
        /// </summary>
        internal static string ErrAssignLiteralValue {
            get {
                return ResourceManager.GetString("ErrAssignLiteralValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid length of char literal - should be a single character. 的本地化字符串。
        /// </summary>
        internal static string ErrBadChar {
            get {
                return ResourceManager.GetString("ErrBadChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Mal-formed  string literal - cannot find termination symbol. 的本地化字符串。
        /// </summary>
        internal static string ErrBadStrLiteral {
            get {
                return ResourceManager.GetString("ErrBadStrLiteral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid unicode escape ({0}), expected {1} hex digits. 的本地化字符串。
        /// </summary>
        internal static string ErrBadUnEscape {
            get {
                return ResourceManager.GetString("ErrBadUnEscape", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid \x escape, at least one digit expected. 的本地化字符串。
        /// </summary>
        internal static string ErrBadXEscape {
            get {
                return ResourceManager.GetString("ErrBadXEscape", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot convert value from type {0} to type {1}, type converter not defined. 的本地化字符串。
        /// </summary>
        internal static string ErrCannotConvertValue {
            get {
                return ResourceManager.GetString("ErrCannotConvertValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot convert literal {0} to type {1}. 的本地化字符串。
        /// </summary>
        internal static string ErrCannotConvertValueToType {
            get {
                return ResourceManager.GetString("ErrCannotConvertValueToType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Fatal error in parser: attempt to move back in the source. 的本地化字符串。
        /// </summary>
        internal static string ErrCannotMoveBackInSource {
            get {
                return ResourceManager.GetString("ErrCannotMoveBackInSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} State {1} on inputs: {2} 的本地化字符串。
        /// </summary>
        internal static string ErrConflictMsgTemplate {
            get {
                return ResourceManager.GetString("ErrConflictMsgTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Fatal error: 的本地化字符串。
        /// </summary>
        internal static string ErrConsoleFatalError {
            get {
                return ResourceManager.GetString("ErrConsoleFatalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Construct &apos;{0}&apos; is not supported (yet) by language implementation. 的本地化字符串。
        /// </summary>
        internal static string ErrConstructNotSupported {
            get {
                return ResourceManager.GetString("ErrConstructNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Could not find a closing quote for quoted value. 的本地化字符串。
        /// </summary>
        internal static string ErrDsvNoClosingQuote {
            get {
                return ResourceManager.GetString("ErrDsvNoClosingQuote", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Duplicate switch &apos;{0}&apos; for regular expression. 的本地化字符串。
        /// </summary>
        internal static string ErrDupRegexSwitch {
            get {
                return ResourceManager.GetString("ErrDupRegexSwitch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Duplicate start symbol {0} in heredoc literal [{1}]. 的本地化字符串。
        /// </summary>
        internal static string ErrDupStartSymbolHereDoc {
            get {
                return ResourceManager.GetString("ErrDupStartSymbolHereDoc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Duplicate start symbol {0} in string literal [{1}]. 的本地化字符串。
        /// </summary>
        internal static string ErrDupStartSymbolStr {
            get {
                return ResourceManager.GetString("ErrDupStartSymbolStr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to create AST node for non-terminal [{0}], error: {1} 的本地化字符串。
        /// </summary>
        internal static string ErrFailedCreateNode {
            get {
                return ResourceManager.GetString("ErrFailedCreateNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to find the ending tag &apos;{0}&apos; for a text literal.  的本地化字符串。
        /// </summary>
        internal static string ErrFreeTextNoEndTag {
            get {
                return ResourceManager.GetString("ErrFreeTextNoEndTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ImpliedSymbolTerminal cannot be used in grammar with DisableScannerParserLink flag set 的本地化字符串。
        /// </summary>
        internal static string ErrImpliedOpUseParserLink {
            get {
                return ResourceManager.GetString("ErrImpliedOpUseParserLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Interpreter error, DataStack.Pop() operation failed - stack is empty. 的本地化字符串。
        /// </summary>
        internal static string ErrInternalErrDataPopFailed {
            get {
                return ResourceManager.GetString("ErrInternalErrDataPopFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Interpreter is busy. 的本地化字符串。
        /// </summary>
        internal static string ErrInterpreterIsBusy {
            get {
                return ResourceManager.GetString("ErrInterpreterIsBusy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid arguments for IncDecNode AST node: either first or second argument should be &apos;--&apos; or &apos;++&apos;. 的本地化字符串。
        /// </summary>
        internal static string ErrInvalidArgsForIncDec {
            get {
                return ResourceManager.GetString("ErrInvalidArgsForIncDec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid AstMode value in call to Evaluate method. Node: {0}, mode: {1}. 的本地化字符串。
        /// </summary>
        internal static string ErrInvalidAstMode {
            get {
                return ResourceManager.GetString("ErrInvalidAstMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid character: &apos;{0}&apos;. 的本地化字符串。
        /// </summary>
        internal static string ErrInvalidChar {
            get {
                return ResourceManager.GetString("ErrInvalidChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid embedded expression.  的本地化字符串。
        /// </summary>
        internal static string ErrInvalidEmbeddedPrefix {
            get {
                return ResourceManager.GetString("ErrInvalidEmbeddedPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid dedent level, no previous matching indent found. 的本地化字符串。
        /// </summary>
        internal static string ErrInvDedent {
            get {
                return ResourceManager.GetString("ErrInvDedent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid escape sequence: \{0}. 的本地化字符串。
        /// </summary>
        internal static string ErrInvEscape {
            get {
                return ResourceManager.GetString("ErrInvEscape", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid escape sequence. 的本地化字符串。
        /// </summary>
        internal static string ErrInvEscSeq {
            get {
                return ResourceManager.GetString("ErrInvEscSeq", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid escape symbol, expected &apos;u&apos; or &apos;U&apos; only. 的本地化字符串。
        /// </summary>
        internal static string ErrInvEscSymbol {
            get {
                return ResourceManager.GetString("ErrInvEscSymbol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Error in heredoc literal [{0}]: No start/end symbols specified. 的本地化字符串。
        /// </summary>
        internal static string ErrInvHereDocDef {
            get {
                return ResourceManager.GetString("ErrInvHereDocDef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Error in heredoc: malformed end literal {0} for heredoc terminal [{1}]. 的本地化字符串。
        /// </summary>
        internal static string ErrInvHereDocEndLiteral {
            get {
                return ResourceManager.GetString("ErrInvHereDocEndLiteral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid number. 的本地化字符串。
        /// </summary>
        internal static string ErrInvNumber {
            get {
                return ResourceManager.GetString("ErrInvNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid switch &apos;{0}&apos; for regular expression 的本地化字符串。
        /// </summary>
        internal static string ErrInvRegexSwitch {
            get {
                return ResourceManager.GetString("ErrInvRegexSwitch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Error in string literal [{0}]: No start/end symbols specified. 的本地化字符串。
        /// </summary>
        internal static string ErrInvStrDef {
            get {
                return ResourceManager.GetString("ErrInvStrDef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The last term of production containing SyntaxError must be a terminal. NonTerminal: {0} 的本地化字符串。
        /// </summary>
        internal static string ErrLastTermOfErrorProd {
            get {
                return ResourceManager.GetString("ErrLastTermOfErrorProd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 List non-terminals cannot be marked transient; list: ({0}) 的本地化字符串。
        /// </summary>
        internal static string ErrListCannotBeTransient {
            get {
                return ResourceManager.GetString("ErrListCannotBeTransient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expected new line symbol. 的本地化字符串。
        /// </summary>
        internal static string ErrNewLineExpected {
            get {
                return ResourceManager.GetString("ErrNewLineExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No closing pair for opening symbol {0} 的本地化字符串。
        /// </summary>
        internal static string ErrNoClosingBrace {
            get {
                return ResourceManager.GetString("ErrNoClosingBrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 AstNodeType or AstNodeCreator is not set on non-terminals: {0}. Either set Term.AstConfig.NodeType, or provide default values in AstContext. 的本地化字符串。
        /// </summary>
        internal static string ErrNodeTypeNotSetOn {
            get {
                return ResourceManager.GetString("ErrNodeTypeNotSetOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No end symbol for regex literal. 的本地化字符串。
        /// </summary>
        internal static string ErrNoEndForRegex {
            get {
                return ResourceManager.GetString("ErrNoEndForRegex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No ending tag &apos;{0}&apos; found in embedded expression. 的本地化字符串。
        /// </summary>
        internal static string ErrNoEndTagInEmbExpr {
            get {
                return ResourceManager.GetString("ErrNoEndTagInEmbExpr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 UnExprNode: no implementation for unary operator &apos;{0}&apos;. 的本地化字符串。
        /// </summary>
        internal static string ErrNoImplForUnaryOp {
            get {
                return ResourceManager.GetString("ErrNoImplForUnaryOp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Number cannot be followed by a letter. 的本地化字符串。
        /// </summary>
        internal static string ErrNoLetterAfterNum {
            get {
                return ResourceManager.GetString("ErrNoLetterAfterNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ParserDataBuilder error: inadequate state {0}, reduce item &apos;{1}&apos; has no lookaheads. 的本地化字符串。
        /// </summary>
        internal static string ErrNoLkhds {
            get {
                return ResourceManager.GetString("ErrNoLkhds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Non-terminal {0} has uninitialized Rule property. 的本地化字符串。
        /// </summary>
        internal static string ErrNtRuleIsNull {
            get {
                return ResourceManager.GetString("ErrNtRuleIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Attempt to evaluate NULL AST node. The AST node for term &apos;{0}&apos; was not created during parsing. 的本地化字符串。
        /// </summary>
        internal static string ErrNullNodeEval {
            get {
                return ResourceManager.GetString("ErrNullNodeEval", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Operator &apos;{0}&apos; is not defined for types {1}. 的本地化字符串。
        /// </summary>
        internal static string ErrOpNotDefinedForType {
            get {
                return ResourceManager.GetString("ErrOpNotDefinedForType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Operator &apos;{0}&apos; is not defined for types {1} and {2}. 的本地化字符串。
        /// </summary>
        internal static string ErrOpNotDefinedForTypes {
            get {
                return ResourceManager.GetString("ErrOpNotDefinedForTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Operator &apos;{0} not imlemented. 的本地化字符串。
        /// </summary>
        internal static string ErrOpNotImplemented {
            get {
                return ResourceManager.GetString("ErrOpNotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0}: {1} 的本地化字符串。
        /// </summary>
        internal static string ErrOutErrorPrintFormat {
            get {
                return ResourceManager.GetString("ErrOutErrorPrintFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 CodeOutlineFilter: line continuation symbol &apos;{0}&apos; should be added to Grammar.NonGrammarTerminals list. 的本地化字符串。
        /// </summary>
        internal static string ErrOutlineFilterContSymbol {
            get {
                return ResourceManager.GetString("ErrOutlineFilterContSymbol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Syntax error, unexpected input. 的本地化字符串。
        /// </summary>
        internal static string ErrParserUnexpectedInput {
            get {
                return ResourceManager.GetString("ErrParserUnexpectedInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Parsed tree is null, cannot evaluate. 的本地化字符串。
        /// </summary>
        internal static string ErrParseTreeNull {
            get {
                return ResourceManager.GetString("ErrParseTreeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Parse tree root is null, cannot evaluate. 的本地化字符串。
        /// </summary>
        internal static string ErrParseTreeRootNull {
            get {
                return ResourceManager.GetString("ErrParseTreeRootNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Root AST node is null, cannot evaluate. 的本地化字符串。
        /// </summary>
        internal static string ErrRootAstNodeNull {
            get {
                return ResourceManager.GetString("ErrRootAstNodeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Root AST node does not implement IInterpretedAstNode interface, cannot evaluate. 的本地化字符串。
        /// </summary>
        internal static string ErrRootAstNoInterface {
            get {
                return ResourceManager.GetString("ErrRootAstNoInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ({0}) term passed as &apos;root&apos; paramater to parserr is not Root or snippet root of the grammar. Add it to SnippetRoots set in grammar constructor. 的本地化字符串。
        /// </summary>
        internal static string ErrRootNotRegistered {
            get {
                return ResourceManager.GetString("ErrRootNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Root property of the grammar is not set. 的本地化字符串。
        /// </summary>
        internal static string ErrRootNotSet {
            get {
                return ResourceManager.GetString("ErrRootNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Reduce-reduce conflict. State {0}, lookaheads: {1}. Selected reduce on first production in conflict set. 的本地化字符串。
        /// </summary>
        internal static string ErrRRConflict {
            get {
                return ResourceManager.GetString("ErrRRConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Rule for NonTerminal {0} contains null as an operand in position {1} in one of productions. 的本地化字符串。
        /// </summary>
        internal static string ErrRuleContainsNull {
            get {
                return ResourceManager.GetString("ErrRuleContainsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Shift-reduce conflict. State {0}, lookaheads [{1}]. Selected shift as preferred action. 的本地化字符串。
        /// </summary>
        internal static string ErrSRConflict {
            get {
                return ResourceManager.GetString("ErrSRConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Syntax error, expected: {0} 的本地化字符串。
        /// </summary>
        internal static string ErrSyntaxErrorExpected {
            get {
                return ResourceManager.GetString("ErrSyntaxErrorExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Syntax error. 的本地化字符串。
        /// </summary>
        internal static string ErrSyntaxErrorNoInfo {
            get {
                return ResourceManager.GetString("ErrSyntaxErrorNoInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expression root non-terminal in template settings (AstNodeConfig property) in templated string literal [{0}] is not added to Roots set. Add it to SnippetRoots in grammar constructor. 的本地化字符串。
        /// </summary>
        internal static string ErrTemplExprNotRoot {
            get {
                return ResourceManager.GetString("ErrTemplExprNotRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expression root is not specified in template settings (AstNodeConfig property) in templated string literal [{0}].  的本地化字符串。
        /// </summary>
        internal static string ErrTemplMissingExprRoot {
            get {
                return ResourceManager.GetString("ErrTemplMissingExprRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Error in string/heredoc literal [{0}]: IsTemplate flag is set, but TemplateSettings is not provided in AstNodeConfig property. 的本地化字符串。
        /// </summary>
        internal static string ErrTemplNoSettings {
            get {
                return ResourceManager.GetString("ErrTemplNoSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A terminal {0} has empty prefix. 的本地化字符串。
        /// </summary>
        internal static string ErrTerminalHasEmptyPrefix {
            get {
                return ResourceManager.GetString("ErrTerminalHasEmptyPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Transient non-terminal must have zero or one non-punctuation child nodes; non-terminals: {0}. 的本地化字符串。
        /// </summary>
        internal static string ErrTransientNtMustHaveOneTerm {
            get {
                return ResourceManager.GetString("ErrTransientNtMustHaveOneTerm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unclosed comment block 的本地化字符串。
        /// </summary>
        internal static string ErrUnclosedComment {
            get {
                return ResourceManager.GetString("ErrUnclosedComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unexpected end of file. 的本地化字符串。
        /// </summary>
        internal static string ErrUnexpEof {
            get {
                return ResourceManager.GetString("ErrUnexpEof", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unexpected indentation. 的本地化字符串。
        /// </summary>
        internal static string ErrUnexpIndent {
            get {
                return ResourceManager.GetString("ErrUnexpIndent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unmatched closing brace &apos;{0}&apos;. 的本地化字符串。
        /// </summary>
        internal static string ErrUnmatchedCloseBrace {
            get {
                return ResourceManager.GetString("ErrUnmatchedCloseBrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Variable {0} is not a callable function. 的本地化字符串。
        /// </summary>
        internal static string ErrVarIsNotCallable {
            get {
                return ResourceManager.GetString("ErrVarIsNotCallable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Variable {0} not defined. 的本地化字符串。
        /// </summary>
        internal static string ErrVarNotDefined {
            get {
                return ResourceManager.GetString("ErrVarNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid number of arguments. Expected {0}, found {1}. 的本地化字符串。
        /// </summary>
        internal static string ErrWrongArgCount {
            get {
                return ResourceManager.GetString("ErrWrongArgCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ({0}:{1}) 的本地化字符串。
        /// </summary>
        internal static string FmtRowCol {
            get {
                return ResourceManager.GetString("FmtRowCol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Accept 的本地化字符串。
        /// </summary>
        internal static string LabelActionAccept {
            get {
                return ResourceManager.GetString("LabelActionAccept", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Operator, shift to {0}/reduce on {1}. 的本地化字符串。
        /// </summary>
        internal static string LabelActionOp {
            get {
                return ResourceManager.GetString("LabelActionOp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Reduce on {0} 的本地化字符串。
        /// </summary>
        internal static string LabelActionReduce {
            get {
                return ResourceManager.GetString("LabelActionReduce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Shift to {0} 的本地化字符串。
        /// </summary>
        internal static string LabelActionShift {
            get {
                return ResourceManager.GetString("LabelActionShift", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (Unknown action type) 的本地化字符串。
        /// </summary>
        internal static string LabelActionUnknown {
            get {
                return ResourceManager.GetString("LabelActionUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (EOF) 的本地化字符串。
        /// </summary>
        internal static string LabelEofMark {
            get {
                return ResourceManager.GetString("LabelEofMark", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [end-of-statement] 的本地化字符串。
        /// </summary>
        internal static string LabelEosLabel {
            get {
                return ResourceManager.GetString("LabelEosLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (INITIAL STATE) 的本地化字符串。
        /// </summary>
        internal static string LabelInitialState {
            get {
                return ResourceManager.GetString("LabelInitialState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (Key symbol) 的本地化字符串。
        /// </summary>
        internal static string LabelKeySymbol {
            get {
                return ResourceManager.GetString("LabelKeySymbol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (Keyword) 的本地化字符串。
        /// </summary>
        internal static string LabelKeyword {
            get {
                return ResourceManager.GetString("LabelKeyword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [line break] 的本地化字符串。
        /// </summary>
        internal static string LabelLineBreak {
            get {
                return ResourceManager.GetString("LabelLineBreak", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Location: 的本地化字符串。
        /// </summary>
        internal static string LabelLocation {
            get {
                return ResourceManager.GetString("LabelLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 None 的本地化字符串。
        /// </summary>
        internal static string LabelNone {
            get {
                return ResourceManager.GetString("LabelNone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ... 的本地化字符串。
        /// </summary>
        internal static string LabelSrcHaveMore {
            get {
                return ResourceManager.GetString("LabelSrcHaveMore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (unnamed) 的本地化字符串。
        /// </summary>
        internal static string LabelUnnamed {
            get {
                return ResourceManager.GetString("LabelUnnamed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Abort script(y/n)? 的本地化字符串。
        /// </summary>
        internal static string MsgAbortScriptYN {
            get {
                return ResourceManager.GetString("MsgAbortScriptYN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} Console.\r\nPress Ctrl-C to exit the program.\r\n 的本地化字符串。
        /// </summary>
        internal static string MsgDefaultConsoleGreeting {
            get {
                return ResourceManager.GetString("MsgDefaultConsoleGreeting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Console 的本地化字符串。
        /// </summary>
        internal static string MsgDefaultConsoleTitle {
            get {
                return ResourceManager.GetString("MsgDefaultConsoleTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Custom action did not execute: parser state or input did not change. 的本地化字符串。
        /// </summary>
        internal static string MsgErrorCustomActionDidNotAdvance {
            get {
                return ResourceManager.GetString("MsgErrorCustomActionDidNotAdvance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Exit console (y/n)? 的本地化字符串。
        /// </summary>
        internal static string MsgExitConsoleYN {
            get {
                return ResourceManager.GetString("MsgExitConsoleYN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 NLALR transform: Add WrapTail() in &apos;.&apos; position to [{0}]. 的本地化字符串。
        /// </summary>
        internal static string MsgNLALRAdvice {
            get {
                return ResourceManager.GetString("MsgNLALRAdvice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Press any key to end the program. 的本地化字符串。
        /// </summary>
        internal static string MsgPressAnyKeyToExit {
            get {
                return ResourceManager.GetString("MsgPressAnyKeyToExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &quot;[{0}], at {1} 的本地化字符串。
        /// </summary>
        internal static string MsgSrcPosToString {
            get {
                return ResourceManager.GetString("MsgSrcPosToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Parsing conflict resolved in code. 的本地化字符串。
        /// </summary>
        internal static string MsgTraceConflictResolved {
            get {
                return ResourceManager.GetString("MsgTraceConflictResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Executing custom action 的本地化字符串。
        /// </summary>
        internal static string MsgTraceExecCustomAction {
            get {
                return ResourceManager.GetString("MsgTraceExecCustomAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Operator - resolved to {0} 的本地化字符串。
        /// </summary>
        internal static string MsgTraceOpResolved {
            get {
                return ResourceManager.GetString("MsgTraceOpResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Popped state from stack, pushing {0} 的本地化字符串。
        /// </summary>
        internal static string MsgTracePoppedState {
            get {
                return ResourceManager.GetString("MsgTracePoppedState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RECOVERING: {0} 的本地化字符串。
        /// </summary>
        internal static string MsgTraceRecoverAction {
            get {
                return ResourceManager.GetString("MsgTraceRecoverAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 FAILED TO RECOVER 的本地化字符串。
        /// </summary>
        internal static string MsgTraceRecoverFailed {
            get {
                return ResourceManager.GetString("MsgTraceRecoverFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RECOVERING: Found state with shift on error : {0} 的本地化字符串。
        /// </summary>
        internal static string MsgTraceRecoverFoundState {
            get {
                return ResourceManager.GetString("MsgTraceRecoverFoundState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RECOVERING: popping stack, looking for state with error shift 的本地化字符串。
        /// </summary>
        internal static string MsgTraceRecovering {
            get {
                return ResourceManager.GetString("MsgTraceRecovering", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RECOVERING: Reached end of error production, reducing. 的本地化字符串。
        /// </summary>
        internal static string MsgTraceRecoverReducing {
            get {
                return ResourceManager.GetString("MsgTraceRecoverReducing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RECOVERING: Shifting Error term, {0} 的本地化字符串。
        /// </summary>
        internal static string MsgTraceRecoverShiftError {
            get {
                return ResourceManager.GetString("MsgTraceRecoverShiftError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RECOVERING: shifting until the end of error production. 的本地化字符串。
        /// </summary>
        internal static string MsgTraceRecoverShiftTillEnd {
            get {
                return ResourceManager.GetString("MsgTraceRecoverShiftTillEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RECOVERED 的本地化字符串。
        /// </summary>
        internal static string MsgTraceRecoverSuccess {
            get {
                return ResourceManager.GetString("MsgTraceRecoverSuccess", resourceCulture);
            }
        }
    }
}
