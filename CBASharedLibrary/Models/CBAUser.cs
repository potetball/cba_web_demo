using System;

namespace CBASharedLibrary
{
  public class CBAUser
  {
    public DateTime? LastActive { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Fullnane { get; set; }

    public string Id { get; set; }
  }

}
