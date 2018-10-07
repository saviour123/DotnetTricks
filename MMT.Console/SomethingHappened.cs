using System;
using Contracts;

namespace MMT.Console
{
class SomethingHappenedMessage : SomethingHappened
  {
    public string What { get; set; }
    public DateTime When { get; set; }
  } 
}