﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using static Module;

public class Class1 : E
{
  public Class1()
  {
    var e = new E();
    int p = e.P;
  }

  protected Class1(SerializationInfo info, StreamingContext context) : base(info, context)
  {
  }
}
