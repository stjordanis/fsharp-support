﻿using JetBrains.ReSharper.Plugins.FSharp.Common.Naming;
using JetBrains.ReSharper.Plugins.FSharp.Psi.Impl.Cache2;
using JetBrains.ReSharper.Psi;

namespace JetBrains.ReSharper.Plugins.FSharp.Psi.Impl.Tree
{
  internal partial class StructDeclaration
  {
    protected override FSharpName GetFSharpName() => Identifier.GetFSharpName(Attributes);
    public override TreeTextRange GetNameRange() => Identifier.GetNameRange();
    public FSharpPartKind TypePartKind => FSharpPartKind.Struct;
  }
}