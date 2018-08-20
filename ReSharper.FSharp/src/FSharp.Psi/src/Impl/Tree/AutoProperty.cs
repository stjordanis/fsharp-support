﻿using JetBrains.ReSharper.Plugins.FSharp.Common.Naming;
using JetBrains.ReSharper.Plugins.FSharp.Psi.Impl.DeclaredElement;
using JetBrains.ReSharper.Psi;
using Microsoft.FSharp.Compiler.SourceCodeServices;

namespace JetBrains.ReSharper.Plugins.FSharp.Psi.Impl.Tree
{
  internal partial class AutoProperty
  {
    protected override FSharpName GetFSharpName() => Identifier.GetFSharpName(Attributes);
    public override TreeTextRange GetNameRange() => Identifier.GetNameRange();

    protected override IDeclaredElement CreateDeclaredElement()
    {
      if (!(GetFSharpSymbol() is FSharpMemberOrFunctionOrValue mfv)) return null;

      if (mfv.IsProperty)
        return new FSharpProperty<AutoProperty>(this, mfv);

      var property = mfv.AccessorProperty;
      return property != null
        ? new FSharpProperty<AutoProperty>(this, property.Value)
        : null;
    }
  }
}