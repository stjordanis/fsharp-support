﻿using JetBrains.ReSharper.Psi;

namespace JetBrains.ReSharper.Plugins.FSharp.Psi.Impl.Tree
{
  internal partial class TypeParameterOfMethodDeclaration
  {
    public override string DeclaredName => Identifier.GetName();
    public override TreeTextRange GetNameRange() => Identifier.GetNameRange();
    public override IDeclaredElement DeclaredElement => null;
  }
}