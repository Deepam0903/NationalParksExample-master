using System;
using System.Collections.Generic;

namespace NationalParks.Models
{
  // Model for parks data. These classes can be obtained by either using 
  // the Visual Studio editor (right-click -> Paste Special -> Paste Json as Classes)
  // or sites such as JsonToCSHarp
  public class Park
  {
    public string candidate_id { get; set; }
    public string candidate_name { get; set; }
    public string candidate_pcc_id { get; set; }
    public string candidate_pcc_name { get; set; }
  }

  public class Parks
  {
    public string total { get; set; }
    public List<Park> data  { get; set; }
    public string per_page { get; set; }
  }
}