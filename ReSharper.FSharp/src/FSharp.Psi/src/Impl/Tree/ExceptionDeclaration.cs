﻿using JetBrains.ReSharper.Plugins.FSharp.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.FSharp.Psi.Impl.Tree
{
  internal partial class ExceptionDeclaration
  {
    protected override string DeclaredElementName => NameIdentifier.GetCompiledName(AllAttributes);
    public override IFSharpIdentifierLikeNode NameIdentifier => (IFSharpIdentifierLikeNode) Identifier;
  }
}